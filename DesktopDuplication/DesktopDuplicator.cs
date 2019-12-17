using System;
using System.Drawing.Imaging;
using System.IO;

using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using Device = SharpDX.Direct3D11.Device;
using MapFlags = SharpDX.Direct3D11.MapFlags;
using Rectangle = SharpDX.Rectangle;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using SharpDX.Mathematics.Interop;

namespace DesktopDuplication
{
    /// <summary>
    /// Provides access to frame-by-frame updates of a particular desktop (i.e. one monitor), with image and cursor information.
    /// </summary>
    public class DesktopDuplicator
    {
        private Device mDevice;
        private Texture2DDescription mTextureDescription;
        private OutputDescription mOutputDescription;
        private OutputDuplication mDeskDuplication;
        Output1 outputStream;

        private OutputDuplicateFrameInformation frameInfo = new OutputDuplicateFrameInformation();
        private int mWhichOutputDevice = -1;
        public enum VSyncLevel
        {
            None,
            Vsync,
            DoubleVsync
        }

        private VSyncLevel vSync;

        private Bitmap finalImage1, finalImage2;
        private bool imageSwitch = false;
        private Bitmap FinalImageDoubleBuffer
        {
            get
            {
                return imageSwitch ? finalImage1 : finalImage2;
            }
            set
            {
                if (imageSwitch)
                {

                    finalImage2 = value;
                    finalImage1?.Dispose();
                }
                else
                {
                    finalImage1 = value;
                    finalImage2?.Dispose();
                }

                imageSwitch = !imageSwitch;
            }
        }

        /// <summary>
        /// Duplicates the output of the specified monitor.
        /// </summary>
        /// <param name="whichMonitor">The output device to duplicate (i.e. monitor). Begins with zero, which seems to correspond to the primary monitor.</param>
        public DesktopDuplicator(int whichMonitor, VSyncLevel vSync)
            : this(0, whichMonitor, vSync) { }

        /// <summary>
        /// Duplicates the output of the specified monitor on the specified graphics adapter.
        /// </summary>
        /// <param name="whichGraphicsCardAdapter">The adapter which contains the desired outputs.</param>
        /// <param name="whichOutputDevice">The output device to duplicate (i.e. monitor). Begins with zero, which seems to correspond to the primary monitor.</param>
        public DesktopDuplicator(int whichGraphicsCardAdapter, int whichOutputDevice, VSyncLevel vSync)
        {
            this.vSync = vSync;
            this.mWhichOutputDevice = whichOutputDevice;
            Adapter1 adapter;
            try
            {
                adapter = new Factory1().GetAdapter1(whichGraphicsCardAdapter);
            }
            catch (SharpDXException)
            {
                throw new DesktopDuplicationException("Could not find the specified graphics card adapter.");
            }
            this.mDevice = new Device(adapter, DeviceCreationFlags.SingleThreaded | DeviceCreationFlags.PreventAlteringLayerSettingsFromRegistry);

            Output output;
            try
            {
                output = adapter.GetOutput(whichOutputDevice);
            }
            catch (SharpDXException)
            {
                throw new DesktopDuplicationException("Could not find the specified output device.");
            }
            outputStream = output.QueryInterface<Output1>();
            this.mOutputDescription = output.Description;
            this.mTextureDescription = new Texture2DDescription()
            {
                CpuAccessFlags = CpuAccessFlags.Read,
                BindFlags = BindFlags.None,
                Format = Format.B8G8R8A8_UNorm,
                Width = this.mOutputDescription.DesktopBounds.Right,
                Height = this.mOutputDescription.DesktopBounds.Bottom,
                OptionFlags = ResourceOptionFlags.None,
                MipLevels = 1,
                ArraySize = 1,
                SampleDescription = { Count = 1, Quality = 0 },
                Usage = ResourceUsage.Staging
            };

            try
            {
                this.mDeskDuplication = outputStream.DuplicateOutput(mDevice);
            }
            catch (SharpDXException err)
            {
                if (err.ResultCode.Code == SharpDX.DXGI.ResultCode.NotCurrentlyAvailable.Result.Code)
                {
                    throw new DesktopDuplicationException("There is already the maximum number of applications using the Desktop Duplication API running, please close one of the applications and try again.");
                }
            }
        }

        /// <summary>
        /// Retrieves the latest desktop image and associated metadata.
        /// </summary>
        public DesktopFrame GetLatestFrame()
        {
            var frame = new DesktopFrame();
            
            if (vSync >= VSyncLevel.Vsync) waitForVSync();
            if (vSync >= VSyncLevel.DoubleVsync) waitForVSync();

            ReleaseFrame();
            
            // Try to get the latest frame; this may timeout
            bool retrievalTimedOut = RetrieveFrame();
            if (retrievalTimedOut) return null;
            
            ProcessFrame(frame);
            
            return frame;
        }

        public void waitForVSync()
        {
            outputStream.WaitForVerticalBlank();
        }

        public void ReleaseFrame()
        {
            try
            {
                mDeskDuplication.ReleaseFrame();
            }
            catch { }
        }

        private Texture2D desktopImageTexture = null;
        SharpDX.DXGI.Resource desktopResource = null;
        private bool RetrieveFrame()
        {
            if (desktopImageTexture == null)
                desktopImageTexture = new Texture2D(mDevice, mTextureDescription);
            frameInfo = new OutputDuplicateFrameInformation();
            try
            {
                mDeskDuplication.AcquireNextFrame(500, out frameInfo, out desktopResource);
            }
            catch (SharpDXException ex)
            {
                if (ex.ResultCode.Code == SharpDX.DXGI.ResultCode.WaitTimeout.Result.Code)
                {
                    return true;
                }
                if (ex.ResultCode.Failure)
                {
                    throw new DesktopDuplicationException("Failed to acquire next frame.");
                }
            }
            using (var tempTexture = desktopResource.QueryInterface<Texture2D>())
            {
                mDevice.ImmediateContext.CopyResource(tempTexture, desktopImageTexture);
            }
            return false;
        }

        private void ProcessFrame(DesktopFrame frame)
        {
            // Get the desktop capture texture
            var mapSource = mDevice.ImmediateContext.MapSubresource(desktopImageTexture, 0, MapMode.Read, MapFlags.None);

            FinalImageDoubleBuffer = new Bitmap(mOutputDescription.DesktopBounds.Right, mOutputDescription.DesktopBounds.Bottom, PixelFormat.Format32bppRgb);

            var boundsRect = new System.Drawing.Rectangle(0, 0, mOutputDescription.DesktopBounds.Right, mOutputDescription.DesktopBounds.Bottom);
            // Copy pixels from screen capture Texture to GDI bitmap
            var mapDest = FinalImageDoubleBuffer.LockBits(boundsRect, ImageLockMode.WriteOnly, FinalImageDoubleBuffer.PixelFormat);
            var sourcePtr = mapSource.DataPointer;
            var destPtr = mapDest.Scan0;
            for (int y = 0; y < mOutputDescription.DesktopBounds.Bottom; y++)
            {
                // Copy a single line 
                Utilities.CopyMemory(destPtr, sourcePtr, mOutputDescription.DesktopBounds.Right * 4);

                // Advance pointers
                sourcePtr = IntPtr.Add(sourcePtr, mapSource.RowPitch);
                destPtr = IntPtr.Add(destPtr, mapDest.Stride);
            }

            // Release source and dest locks
            FinalImageDoubleBuffer.UnlockBits(mapDest);
            mDevice.ImmediateContext.UnmapSubresource(desktopImageTexture, 0);
            frame.DesktopImage = FinalImageDoubleBuffer;
        }
    }
}
