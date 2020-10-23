using System;
using System.Windows.Forms;

namespace PosSystem
{
    internal class UserDetailsCheckInput
    {
        internal static bool TextboxesFilled(GroupBox groupBox1)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                    if (((TextBox)item).Text == string.Empty)
                    {
                        MessageBox.Show("One of the textboxes is empty");
                        return false;
                    }
            }
            return true;
        }

        internal static bool Age(string stringAge)
        {
            try
            {
                int age = int.Parse(stringAge);
                return age >= 0 && age <= 99 ? true : throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Age format incorrect");
                return false;
            }
        }
    }
}