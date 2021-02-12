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
    public partial class RemoveCB : UserControl
    {
        public RemoveCB()
        {
            InitializeComponent();
        }

        private void RemoveCB_VisibleChanged(object sender, EventArgs e)
        {
            infos.Text = "POMPE N°1\n\r" + Program.fuel;
        }
    }
}
