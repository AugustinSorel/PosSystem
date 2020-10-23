using System.Linq;
using System.Windows.Forms;

namespace PosSystem
{
    internal class CheckWorkerAge
    {
        internal static bool CheckIfInteger(string age)
        {
            if (age.All(char.IsDigit))
                return true;
            else
            {
                MessageBox.Show("Age format is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}