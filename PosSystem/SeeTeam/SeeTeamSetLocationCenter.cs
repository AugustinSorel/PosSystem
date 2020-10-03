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
    }
}
