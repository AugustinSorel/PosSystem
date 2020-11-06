using System;
using System.Windows.Forms;

namespace PosSystem
{
    internal class CategoryCheckInput
    {
        internal static bool TextboxesFilled(GroupBox groupBox1)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                    if (((TextBox)item).Text == string.Empty)
                    {
                        MessageBox.Show("One of the textboxes is empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
            }
            return true;
        }
    }
}