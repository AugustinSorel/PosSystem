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
            HideControlsForNonAdmin();
        }

        private void HideControlsForNonAdmin()
        {
            if (! UserDetailsVAR.Admin)
                panel2.Visible = false;
        }

        private void SetComponentsLocation()
        {
            SetLabelsLocation();
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

        private void GetHomePage()
        {
            new CreateHomePage();
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
            new BackToLoginPage();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new CreateUserDetails();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new CreateSeeTeam();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new CreateManageWorker();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new CreateManageItem();
        }
    }
}
