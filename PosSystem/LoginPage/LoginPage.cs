using System.Windows.Forms;

namespace PosSystem
{
    public partial class LoginPage : UserControl
    {
        public int GetLoginPageWidth => Width;
        public Label GetLoginPageLabel1 => label1;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, System.EventArgs e)
        {
            label1.Location = SetLocationLoginPage.SetLabel1Location();
            button1.Location = new System.Drawing.Point(Width/2 - button1.Width/2, 350);
        }

        private void TextBox1_TextChanged(object sender, System.EventArgs e)
        {
            label1.Text = "Welcome back, " + textBox1.Text;
            label1.Location = new System.Drawing.Point(Width / 2 - label1.Width / 2, 50);
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Textbox1NotEmpty())
            {
                textBox2.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private bool Textbox1NotEmpty()
        {
            return textBox1.Text != string.Empty;
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Textbox2NotEmpty())
                MessageBox.Show("loged in");
        }

        private bool Textbox2NotEmpty()
        {
            return textBox2.Text != string.Empty;
        }
    }
}
