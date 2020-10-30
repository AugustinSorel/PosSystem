using System.Drawing;
using System.Windows.Forms;

namespace PosSystem
{
    internal class OrderLocation
    {
        internal static Point SetPanel1(int width)
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width / 2 - width / 2, Screen.PrimaryScreen.Bounds.Width / 2 - 600);
        }

        internal static Point SetPanel2(int width)
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width / 2 - width / 2, Screen.PrimaryScreen.Bounds.Height - 400);
        }

        internal static Point FinaPrice()
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width - 400, Screen.PrimaryScreen.Bounds.Height - 100);
        }

        internal static Point Panel3(int width)
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width / 2 - width / 2, 0);
        }

        internal static Point GroupBox2(int width)
        {
             return new Point(Screen.PrimaryScreen.Bounds.Width / 2 - width / 2, 100);
        }
    }
}