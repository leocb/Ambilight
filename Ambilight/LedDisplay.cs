using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbilightController
{
    public partial class LED : UserControl
    {
        public void SetColor(int r, int g, int b)
        {
            this.BackColor = Color.FromArgb(r, g, b);
        }

        public LED()
        {
            InitializeComponent();
            BackColor = Color.Black;
        }
    }
}
