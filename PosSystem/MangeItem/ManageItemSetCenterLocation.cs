using System.Drawing;
using System.Windows.Forms;

namespace PosSystem
{
    class ManageStockSetCenterLocation
    {
        public static Point Panel1Center(int Panel1Width)
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Panel1Width / 2, 0);
        }

        internal static Point Panel2Center(int width)
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width / 2 - width / 2, Screen.PrimaryScreen.Bounds.Width / 2 - 300);
        }
    }
}
