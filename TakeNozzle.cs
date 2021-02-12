using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PompeEssence
{
    public partial class TakeNozzle : UserControl
    {
        public TakeNozzle()
        {
            InitializeComponent();
        }

        private void TakeNozzle_VisibleChanged(object sender, EventArgs e)
        {
            takeNozzleText.Text = "Veuillez prendre\n\rle pistolet de\n\r" + Program.fuel;
        }
    }
}
