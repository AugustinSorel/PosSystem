using System;
using System.Drawing;
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
            Dock = SetDockStyleMenu();
            TriggerButton1Click();
        }

        private void TriggerButton1Click()
        {
            button1.PerformClick();
        }

        private DockStyle SetDockStyleMenu()
        {
            return DockStyle.Left;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CreateHomePage();
        }

        private static void CreateHomePage()
        {
            // TODO: If Statment, check child of panel1. if it contain a child then distroy it, else create a homePage
            (Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel).Controls.Add(new HomePage());
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Regular);
            Form.ActiveForm.Cursor = Cursors.Default;
        }

        private void Label2_MouseEnter(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Underline);
            Form.ActiveForm.Cursor = Cursors.Hand;
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            // TODO: CLEAN THIS GARBAGE
            Dispose();

            Panel panel = Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel;
            foreach (Control item in panel.Controls.OfType<UserControl>())
                panel.Controls.Remove(item);

            Form.ActiveForm.Size = new Size(500, 400);
            Form.ActiveForm.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Form.ActiveForm.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - Form.ActiveForm.Height) / 2);

            panel.Controls.Add(new LoginPage());
            // TODO: when new loginPage, select textbox
        }
    }
}
