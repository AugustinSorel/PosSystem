using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PosSystem
{
    static class BackToLoginPage
    {
        private static Panel Panel;

        public static void GetBackToLoginPage()
        {
            Panel = GetPanelFromForm();
            RemoveMenuPage();
            RemoveControlsFromPanel();
            ResizeForm();
            SetLocationCenterScreen();
            AddNewLoginPage();
        }

        private static void RemoveMenuPage()
        {
            (Form.ActiveForm.Controls.Find("Menu", true).FirstOrDefault() as Menu).Dispose();
        }

        private static void AddNewLoginPage()
        {
            Panel.Controls.Add(new LoginPage());
        }

        private static void SetLocationCenterScreen()
        {
            Form.ActiveForm.Location = new Point(GetMiddleX(), GetMiddleY());
        }

        private static int GetMiddleX()
        {
            return (Screen.PrimaryScreen.WorkingArea.Width - Form.ActiveForm.Width) / 2;
        }

        private static int GetMiddleY()
        {
            return (Screen.PrimaryScreen.WorkingArea.Height - Form.ActiveForm.Height) / 2;
        }

        private static void ResizeForm()
        {
            Form.ActiveForm.Size = new Size(500, 400);
        }

        private static void RemoveControlsFromPanel()
        {
            foreach (Control item in Panel.Controls.OfType<UserControl>())
                Panel.Controls.Remove(item);
        }

        private static Panel GetPanelFromForm()
        {
            return Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel;
        }
    }
}
