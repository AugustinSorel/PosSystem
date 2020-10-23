using System.Linq;
using System.Windows.Forms;

namespace PosSystem
{
    internal class StockCheckInput
    {
        internal static bool CheckTextboxesFilled(GroupBox groupBox1)
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

        internal static bool CheckMinAndMax(string StringMax, string stringMin)
        {
            if (CheckInteger(StringMax) && CheckInteger(stringMin))
            {
                int max = int.Parse(StringMax);
                int min = int.Parse(stringMin);
                if (max < min)
                {
                    MessageBox.Show("Stock max cant be smaller than stock min");
                    return false;
                }
                else
                    return true;
            }
            else
                return false;
        }

        internal static bool CheckInteger(string text)
        {
            if (text.All(char.IsDigit))
                return true;
            else
            {
                MessageBox.Show("number format is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}