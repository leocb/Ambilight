using System.Windows.Forms;
using AmbilightController;

namespace AmbilightController
{
    public partial class LedDisplay : UserControl
    {
        public LedDisplay()
        {
            InitializeComponent();
        }


        public enum ScreenRegion
        {
            Top,
            Right,
            Bottom,
            Left
        }


        public void UpdateDisplayQuantity(decimal quantity, ScreenRegion region)
        {
            TableLayoutPanel panel = GetPanelByRegion(region);

            panel.SuspendLayout();

            if (panel.HasChildren) panel.Controls.Clear();

            if (region == ScreenRegion.Top || region == ScreenRegion.Bottom)
            {
                panel.ColumnCount = 0;
                panel.ColumnStyles.Clear();
                panel.Controls.Clear();
                for (int i = 0; i < quantity; i++)
                {
                    LedPoint led = new LedPoint();
                    led.Dock = DockStyle.Fill;
                    led.Margin = new Padding(1);

                    panel.ColumnCount++;
                    panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    panel.Controls.Add(led, i, 0);
                }
            }
            else
            {

                panel.RowCount = 0;
                panel.RowStyles.Clear();
                panel.Controls.Clear();
                for (int i = 0; i < quantity; i++)
                {
                    LedPoint led = new LedPoint();
                    led.Dock = DockStyle.Fill;
                    led.Margin = new Padding(1);

                    panel.RowCount++;
                    panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    panel.Controls.Add(led, i, 0);
                }
            }

            panel.ResumeLayout();
        }

        private TableLayoutPanel GetPanelByRegion(ScreenRegion region)
        {
            switch (region)
            {
                case ScreenRegion.Top:
                    return LedPanelTop;
                case ScreenRegion.Right:
                    return LedPanelRight;
                case ScreenRegion.Bottom:
                    return LedPanelBottom;
                case ScreenRegion.Left:
                    return LedPanelLeft;
                default:
                    return null;
            }
        }

    }
}
