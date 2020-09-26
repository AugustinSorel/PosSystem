using System.Windows.Forms;

namespace PosSystem
{
    class LoginPageTextBox
    {
        public static bool Textbox2NotEmpty(TextBox textBox)
        {
            return textBox.Text != string.Empty;
        }

        public static bool Textbox1NotEmpty(TextBox textBox)
        {
            return textBox.Text != string.Empty;
        }

        public static bool CheckTextbox1Range(TextBox textBox)
        {
            return textBox.Text.Length >= 20;
        }

        public static string ChangeTextBox1Text(TextBox textBox)
        {
            return "Welcome back, " + textBox.Text;
        }
    }
}
