using System.Windows.Forms;

namespace PosSystem
{
    internal class ManageSupplierClearControls
    {
        public ManageSupplierClearControls(ManageSupplier manageSupplier)
        {
            foreach (Control item in manageSupplier.groupBox1.Controls)
                if (item is TextBox)
                    ((TextBox)item).Clear();
        }
    }
}