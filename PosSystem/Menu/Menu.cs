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
            SetComponentsLocation();
        }

        private void SetComponentsLocation()
        {
            SetLabelsLocation();
            SetButtonsLocation();
        }

        private void SetButtonsLocation()
        {
            button1.Location = MenuSetLocation.SetButtonLocation(Width, button1.Width, 100);
            button2.Location = MenuSetLocation.SetButtonLocation(Width, button2.Width, 150);
            button3.Location = MenuSetLocation.SetButtonLocation(Width, button3.Width, 200);
        }

        private void SetLabelsLocation()
        {
            label2.Location = MenuSetLocation.SetLabelLocation(Width, label2.Width);
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
