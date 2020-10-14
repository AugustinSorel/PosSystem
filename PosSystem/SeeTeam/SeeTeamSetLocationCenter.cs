using System;
using System.Drawing;
using System.Windows.Forms;

namespace PosSystem
{
    class SeeTeamSetLocationCenter
    {
        public static Point SetPanel1(int Panel1Width)
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Panel1Width / 2, 0);
        }

        public static Point SetDataGridView(int dataGridViewWidth, int dataGridViewHeight)
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width / 2 - dataGridViewWidth / 2, Screen.PrimaryScreen.Bounds.Height - dataGridViewHeight - 100);
        }

        internal static Point SetPanel2(int Panel2Width, int Panel2Height)
        {
            return new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Panel2Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - Panel2Height / 2 + 100);
        }
    }
}
