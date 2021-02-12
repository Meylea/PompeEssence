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
    public partial class Actions : Form
    {
        public delegate void DelegateClickBtn(string button);
        public event DelegateClickBtn clickBtn;
        public Actions()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Name);
            }
        }
    }
}
