using System.Linq;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class LoginPage : UserControl
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, System.EventArgs e)
        {
            label1.Location = SetLocationLoginPage.SetLabelLocation(Width, label1.Width);
            button1.Location = SetLocationLoginPage.SetButtonLocation(Width, button1.Width);
        }

        private void TextBox1_TextChanged(object sender, System.EventArgs e)
        {
            label1.Text = LoginPageTextBox.ChangeTextBox1Text(textBox1);
            label1.Location = SetLocationLoginPage.SetLabelLocation(Width, label1.Width);
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                e.SuppressKeyPress = true;
            }

            if (LoginPageTextBox.CheckTextbox1Range(textBox1) && e.KeyCode != Keys.Back)
                e.SuppressKeyPress = true;
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                button1.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            if (LoginPageTextBox.Textbox1NotEmpty(textBox1) && LoginPageTextBox.Textbox2NotEmpty(textBox2))
            {
                Dispose();
                ShowMenu();
            }
        }

        private static void ShowMenu()
        {
            (Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel).Controls.Add(new Menu());
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
           Form.ActiveForm.Bounds = Screen.PrimaryScreen.Bounds;
        }        
    }
}
