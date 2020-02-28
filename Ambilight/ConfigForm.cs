using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopDuplication;
using static AmbilightController.LedDisplay;

namespace AmbilightController
{
    public partial class ConfigForm : Form
    {

        private bool PerformanceMonitoringIsActive = true;
        private DesktopDuplicator desktopDuplicator;
        Stopwatch sw = new Stopwatch();

        LedDisplayForm ledsView = new LedDisplayForm();

        public ConfigForm()
        {
            InitializeComponent();

            try
            {
                desktopDuplicator = new DesktopDuplicator(0, DesktopDuplicator.VSyncLevel.DoubleVsync);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //if (!performanceMonitor) chart1.Visible = false;
            if (PerformanceMonitoringIsActive) PerformanceMonitorEvent += frame_status_update;
        }

        #region desktop capture
        private void ConfigForm_Shown(object sender, EventArgs e)
        {
            Thread CaptureLoopThread = new Thread(() =>
            {
                if (PerformanceMonitoringIsActive) sw.Restart();
                captureLoop();
            });
            CaptureLoopThread.Start();
        }
        DesktopFrame frame = null;

        private void captureLoop()
        {
            try
            {
                while (!stopUpdate)
                {
                    try
                    {
                        frame = desktopDuplicator.GetLatestFrame();
                    }
                    catch { }

                    if (frame == null) continue;

                    // uncomment the line bellow to enable drawing on screen
                    // if(updateBgEnabled) BackgroundImage = frame.DesktopImage;

                    PerformanceMonitorEvent?.BeginInvoke(sw.Elapsed.TotalMilliseconds, null, null);
                    if (PerformanceMonitoringIsActive) sw.Restart();
                }
            }
            catch (ThreadAbortException) { }
        }

        private delegate void frameEventDelegate(double frameMS);
        private static event frameEventDelegate PerformanceMonitorEvent;

        private void frame_status_update(double frameMS)
        {
            if (stopUpdate) return;
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new frameEventDelegate(frame_status_update), new object[] { frameMS });
                }
                catch { }
                return;
            }

            //if (chart1.Series[0].Points.Count > 200)
            //    chart1.Series[0].Points.RemoveAt(0);
            //chart1.Series[0].Points.Add(Math.Round(1000 / frameMS));
            Text = Math.Round(1000 / frameMS).ToString();
        }
        #endregion

        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopUpdate = true;
        }

        private bool stopUpdate = false;


        private void ConfigForm_Load(object sender, EventArgs e)
        {
            UpdateControls();
            ledsView.Show();
        }

        #region settings
        private void ledChangeDirection_Click(object sender, EventArgs e)
        {
            ledChangeDirectionButton.Text = ledChangeDirectionButton.Text.Contains("Counter") ? "Clockwise" : "Counter-Clockwise";
        }

        private void ledSettingsApply_Click(object sender, EventArgs e)
        {
            UpdateLedSettingsValues();
            UpdateControls();
        }

        private void UpdateControls()
        {
            ledsView.ledDisplay.UpdateDisplayQuantity(ledCountTopControl.Value, ScreenRegion.Top);
            ledsView.ledDisplay.UpdateDisplayQuantity(ledCountRightControl.Value, ScreenRegion.Right);
            ledsView.ledDisplay.UpdateDisplayQuantity(ledCountBottomControl.Value, ScreenRegion.Bottom);
            ledsView.ledDisplay.UpdateDisplayQuantity(ledCountLeftControl.Value, ScreenRegion.Left);
        }

        private void UpdateLedSettingsValues()
        {

        }
        #endregion
    }
}
