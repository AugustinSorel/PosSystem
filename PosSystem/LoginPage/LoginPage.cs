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
            BtnLogin.Location = SetLocationLoginPage.SetButtonLocation(Width, BtnLogin.Width);
            txtboxUsername.Focus();
        }

        private void TextBox1_TextChanged(object sender, System.EventArgs e)
        {
            label1.Text = LoginPageTextBox.ChangeTextBox1Text(txtboxUsername);
            label1.Location = SetLocationLoginPage.SetLabelLocation(Width, label1.Width);
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtboxPassword.Focus();
                e.SuppressKeyPress = true;
            }

            if (TextBoxInRange() && e.KeyCode != Keys.Back)
                e.SuppressKeyPress = true;
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                BtnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            if (TextBoxNotEmpty() && RightLogDetails()) 
            {
                SetUserDetailsVar();
                Dispose();
                ShowMenu();
            }
            else
                MessageBox.Show("The username or password is incorrect", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SetUserDetailsVar()
        {
            new SetUserDetailsVar(txtboxUsername.Text, txtboxPassword.Text); 
        }

        private bool TextBoxNotEmpty()
        {
            return LoginPageTextBox.Textbox1NotEmpty(txtboxUsername) && LoginPageTextBox.Textbox2NotEmpty(txtboxPassword);
        }

        private bool RightLogDetails()
        {
            return CheckLoginDetails.LoginDetailsIsCorrect(txtboxUsername.Text, txtboxPassword.Text);
        }

        private void ShowMenu()
        {
            (Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel).Controls.Add(new Menu());
        }

        private bool TextBoxInRange()
        {
            return LoginPageTextBox.CheckTextbox1Range(txtboxUsername);
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
           Form.ActiveForm.Bounds = Screen.PrimaryScreen.Bounds;
        }        
    }
}
