using System.Threading.Tasks;
using System.Windows.Forms;

namespace PompeEssence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Actions Actions = new Actions();
            Actions.Show();
            Actions.clickBtn += Actions_clickBtn;
            fuelSelection1.clickBtn += FuelSelection1_clickBtn;
            code1.clickBtn += Code1_clickBtn;
 
        }

        private void Code1_clickBtn(string code)
        {
            if (code != "cancel")
            {
                code1.Visible = false;
                goodCode1.Visible = true;
                var t = Task.Delay(3000);
                t.Wait();
                goodCode1.Visible = false;
                removeCB1.Visible = true;
            }
            else
            {
                home1.Visible = true;
            }
        }

        private void FuelSelection1_clickBtn(string button)
        {
            fuelSelection1.Visible = false;
            if (button != "cancel")
            {
                Program.fuel = button;
                code1.Visible = true;
            } else
            {
                home1.Visible = true;
            }
        }

        private void Actions_clickBtn(string button)
        {
            if (button == "insertCart")
            {
                home1.Visible = false;
                wait1.Visible = true;
                var t = Task.Delay(3000);
                t.Wait();
                wait1.Visible = false;
                fuelSelection1.Visible = true;
            } else if (button == "removeCB")
            {
                removeCB1.Visible = false;
                takeNozzle1.Visible = true;
            } else if (button == "takeNozzle")
            {
                takeNozzle1.Visible = false;
                delivery1.Visible = true;
            }
        }
    }
}
