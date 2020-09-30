using System.Windows.Forms;

namespace PosSystem
{
    class UserDetailsSetLocation
    {
        public static System.Drawing.Point CenterGroupBox(int panelWidth, int panelHeight)
        {
            return new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width / 2 - panelWidth / 2, Screen.PrimaryScreen.Bounds.Height / 2 - panelHeight / 2);
        }
    }
}
