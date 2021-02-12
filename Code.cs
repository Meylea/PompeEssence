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
    public partial class Code : UserControl
    {
        public delegate void DelegateClickBtn(string button);
        public event DelegateClickBtn clickBtn;
        private string code = String.Empty;

        public Code()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            if (code.Length < 4)
            {
                code += ((Button)sender).Text;
                codeBox.Text += "*";
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Name);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (code.Length < 0)
            {
                code = code.Remove(code.Length - 1, 1);
                codeBox.Text = codeBox.Text.Remove(codeBox.Text.Length - 1, 1);
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (clickBtn != null && code.Length == 4)
            {
                clickBtn(code);
            }
        }
    }
}
