using System.Windows.Forms;

namespace PosSystem
{
    internal class StockClearControls
    {
        public StockClearControls(GroupBox groupBox1, GroupBox groupBox2)
        {
            foreach (Control item in groupBox1.Controls)
                if (item is TextBox)
                    ((TextBox)item).Text = string.Empty;

            foreach (Control item in groupBox2.Controls)
                if (item is TextBox)
                    ((TextBox)item).Text = string.Empty;
        }
    }
}