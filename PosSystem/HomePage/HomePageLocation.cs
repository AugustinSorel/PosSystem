using System;
using System.Drawing;
using System.Windows.Forms;

namespace PosSystem
{
    internal class HomePageLocation
    {
        internal static Point SetGraphLocation(int width)
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width / 2 - width / 2, 0);
        }
    }
}