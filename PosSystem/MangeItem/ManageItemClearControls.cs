using System.Windows.Forms;

namespace PosSystem
{
    class ManageStockClearControls
    {
        public ManageStockClearControls(ManageItem manageStock)
        {
            foreach (Control item in manageStock.groupBox1.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = string.Empty;
            }

            foreach (Control item in manageStock.groupBox2.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = string.Empty;
            }

            manageStock.txtboxQuantity.Text = 0.ToString();
            manageStock.pictureBoxItem.Image = Properties.Resources.DefaultItem;
        }
    }
}
