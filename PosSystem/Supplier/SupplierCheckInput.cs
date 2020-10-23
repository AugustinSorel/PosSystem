using System.Linq;
using System.Windows.Forms;

namespace PosSystem
{
    internal class SupplierCheckInput
    {
        internal static bool TextBoxesFilled(GroupBox groupBox1)
        {
            foreach (Control item in groupBox1.Controls)
                if (item is TextBox)
                    if (((TextBox)item).Text == string.Empty)
                    {
                        MessageBox.Show("One of the textboxes is empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

            return true;
        }

        internal static bool PhoneNumber(string phone)
        {
            if (phone.All(char.IsDigit))
                return true;
            else
            {
                MessageBox.Show("Phone number format is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}