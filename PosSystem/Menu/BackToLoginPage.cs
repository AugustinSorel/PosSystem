using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PosSystem
{
    class BackToLoginPage
    {
        private static Panel Panel;

        public BackToLoginPage()
        {
            Panel = GetPanelFromForm();
            RemoveMenuPage();
            RemoveControlsFromPanel();
            ResizeForm();
            SetLocationCenterScreen();
            AddNewLoginPage();
        }

        private void RemoveMenuPage()
        {
            (Form.ActiveForm.Controls.Find("Menu", true).FirstOrDefault() as Menu).Dispose();
        }

        private void AddNewLoginPage()
        {
            Panel.Controls.Add(new LoginPage());
        }

        private void SetLocationCenterScreen()
        {
            Form.ActiveForm.Location = new Point(GetMiddleX(), GetMiddleY());
        }

        private int GetMiddleX()
        {
            return (Screen.PrimaryScreen.WorkingArea.Width - Form.ActiveForm.Width) / 2;
        }

        private int GetMiddleY()
        {
            return (Screen.PrimaryScreen.WorkingArea.Height - Form.ActiveForm.Height) / 2;
        }

        private void ResizeForm()
        {
            Form.ActiveForm.Size = new Size(500, 400);
        }

        private void RemoveControlsFromPanel()
        {
            foreach (Control item in Panel.Controls.OfType<UserControl>())
                Panel.Controls.Remove(item);
        }

        private Panel GetPanelFromForm()
        {
            return Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel;
        }
    }
}
