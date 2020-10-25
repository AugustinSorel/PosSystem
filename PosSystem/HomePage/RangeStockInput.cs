using System.Linq;
using System.Windows.Forms;

namespace PosSystem
{
    internal class RangeStockInput
    {
        internal static bool checkRange(string input)
        {
            if (input.All(char.IsDigit))
                return true;
            else
            {
                MessageBox.Show("Input format is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}