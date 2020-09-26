using System;
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
            GetHomePage();
        }

        private static void GetHomePage()
        {
            CreateHomePage.CreateNewHomePage();
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {
            MenuPageLabelEffect.MouseLeave(label2);
        }

        private void Label2_MouseEnter(object sender, EventArgs e)
        {
            MenuPageLabelEffect.MouseEnter(label2);
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            BackToLoginPage.GetBackToLoginPage();
        }
    }
}
