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
    }
}
