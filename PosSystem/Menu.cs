using System;
using System.Linq;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Left;
            button1.PerformClick();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            (Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel).Controls.Add(new HomePage());
        }
    }
}
