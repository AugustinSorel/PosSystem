using System.Windows.Forms;

namespace PosSystem
{
    class CheckAdminRight
    {
        public static bool Check(CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to give admin right this worker ?", "Warning", MessageBoxButtons.YesNo);
                return dialogResult == DialogResult.Yes;
            }
            else
                return true;
        }
    }
}
