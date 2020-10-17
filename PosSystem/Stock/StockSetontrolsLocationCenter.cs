using System;
using System.Drawing;
using System.Windows.Forms;

namespace PosSystem
{
    internal class StockSetontrolsLocationCenter
    {
        internal static Point Panel1(int panelWidth)
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width / 2 - panelWidth / 2, 0);
        }

        internal static Point DataGridView(int dataGridWidth)
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width / 2 - dataGridWidth / 2, Screen.PrimaryScreen.Bounds.Height - 250);
        }

        internal static Point SetPanel2(int Panel2Width, int Panel2Height)
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Panel2Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - Panel2Height / 2 + 100);
        }
    }
}