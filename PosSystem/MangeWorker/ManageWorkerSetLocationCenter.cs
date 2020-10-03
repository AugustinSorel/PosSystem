using System.Windows.Forms;

namespace PosSystem
{
    class ManageWorkerSetLocationCenter
    {
        public static System.Drawing.Point CenterPanel1(int panelWidth, int panelHeight)
        {
            return new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width / 2 - panelWidth / 2, Screen.PrimaryScreen.Bounds.Height / 3 - panelHeight / 2);
        }

        public static System.Drawing.Point CenterPanel2(int panelWidth, int panelHeight)
        {
            return new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width / 2 - panelWidth / 2, Screen.PrimaryScreen.Bounds.Height / 1 - panelHeight / 2);
        }
    }
}
