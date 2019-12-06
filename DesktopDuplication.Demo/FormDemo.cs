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

namespace DesktopDuplication.Demo
{
    public partial class FormDemo : Form
    {
        private DesktopDuplicator desktopDuplicator;

        public FormDemo()
        {
            InitializeComponent();

            try
            {
                desktopDuplicator = new DesktopDuplicator(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            frameEvent += frame_status_update;
        }


        private void FormDemo_Shown(object sender, EventArgs e)
        {
            Thread t = new Thread(frame_capture_loop);
            t.Start();
        }

        private delegate void frameEventDelegate(double frameMS);
        private static event frameEventDelegate frameEvent;

        private void frame_status_update(double frameMS)
        {
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new frameEventDelegate(frame_status_update), new object[] { frameMS });
                }
                catch { }
                return;
            }

            if (chart1.Series[0].Points.Count > 200)
                chart1.Series[0].Points.RemoveAt(0);
            chart1.Series[0].Points.Add(Math.Round(1000 / frameMS));
            Text = Math.Round(1000 / frameMS).ToString();
        }

        private void frame_capture_loop()
        {
            Stopwatch sw = new Stopwatch();
                sw.Restart();
            while (!stopUpdate)
            {
                DesktopFrame frame = null;
                try
                {
                    frame = desktopDuplicator.GetLatestFrame(false, true);
                }
                catch
                {
                    continue;
                }

                if (frame != null)
                {
                    //LabelCursor.Location = frame.CursorLocation;
                    //LabelCursor.Visible = frame.CursorVisible;
                    ////Debug.WriteLine("--------------------------------------------------------");
                    //foreach (var moved in frame.MovedRegions)
                    //{
                    //    //Debug.WriteLine(String.Format("Moved: {0} -> {1}", moved.Source, moved.Destination));
                    //    MovedRegion.Location = moved.Destination.Location;
                    //    MovedRegion.Size = moved.Destination.Size;
                    //}
                    //foreach (var updated in frame.UpdatedRegions)
                    //{
                    //    //Debug.WriteLine(String.Format("Updated: {0}", updated.ToString()));
                    //    UpdatedRegion.Location = updated.Location;
                    //    UpdatedRegion.Size = updated.Size;
                    //}
                    //this.BackgroundImage = frame.DesktopImage;
                }
                sw.Stop();
                frameEvent?.BeginInvoke(sw.Elapsed.TotalMilliseconds,null,null);
                sw.Restart();
            }
        }

        private void FormDemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopUpdate = true;
        }

        private bool stopUpdate = false;
    }
}
