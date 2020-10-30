using System.Drawing;
using System.Windows.Forms;

namespace PosSystem
{
    internal class SaleSetLocation
    {
        internal static Point GroupBox1(int width)
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width / 2 - width / 2, 100);
        }

        internal static Point GroupBox2(int width)
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width / 2 - width / 2, Screen.PrimaryScreen.Bounds.Width / 2 - 500);
        }

        internal static Point FinaPrice()
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width - 700 , Screen.PrimaryScreen.Bounds.Width / 2 - 100);
        }

        internal static Point Panel2(int width)
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width / 2 - width / 2, 0);
        }
    }
}