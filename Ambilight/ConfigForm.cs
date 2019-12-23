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

namespace AmbilightController
{
    public partial class ConfigForm : Form
    {

        private bool performanceMonitor = true;
        private DesktopDuplicator desktopDuplicator;
        Stopwatch sw = new Stopwatch();

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
            if (performanceMonitor) PerformanceMonitorEvent += frame_status_update;
        }

        private void ConfigForm_Shown(object sender, EventArgs e)
        {
            Thread tr = new Thread(() =>
            {
                if (performanceMonitor) sw.Restart();
                captureLoop();
            });
            tr.Start();
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
                    if (performanceMonitor) sw.Restart();
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

        private void FormDemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopUpdate = true;
        }

        private bool stopUpdate = false;
        private bool updateBgEnabled = true;

        private void FormDemo_ResizeBegin(object sender, EventArgs e)
        {
            BackgroundImage = null;
            updateBgEnabled = false;
        }

        private void FormDemo_ResizeEnd(object sender, EventArgs e)
        {
            updateBgEnabled = true;
        }
    }
}
