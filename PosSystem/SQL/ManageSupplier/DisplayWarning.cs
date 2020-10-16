using System.Windows.Forms;

namespace PosSystem
{
    internal class DisplayWarning
    {
        internal static bool Message()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete this Supplier ?", "Warning", MessageBoxButtons.YesNo);
            return dialogResult == DialogResult.Yes;
        }
    }
}