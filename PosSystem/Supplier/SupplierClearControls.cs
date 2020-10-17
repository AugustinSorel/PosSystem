using System.Windows.Forms;

namespace PosSystem
{
    internal class SupplierClearControls
    {
        public SupplierClearControls(Supplier supplier)
        {
            foreach (Control item in supplier.groupBox1.Controls)
                if (item is TextBox)
                    ((TextBox)item).Clear();

            supplier.TxtBoxSearchName.Clear();
        }
    }
}