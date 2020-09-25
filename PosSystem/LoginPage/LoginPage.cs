using System.Linq;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class LoginPage : UserControl
    {
        private const string WELCOME = "Welcome back, ";

        public LoginPage()
        {
            InitializeComponent();
        }

        // TODO: Create class for function

        private void LoginPage_Load(object sender, System.EventArgs e)
        {
            label1.Location = SetLabelLocation();
            button1.Location = SetButtonLocation();
        }

        private void TextBox1_TextChanged(object sender, System.EventArgs e)
        {
            label1.Text = WELCOME + textBox1.Text;
            label1.Location = SetLabelLocation();
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                e.SuppressKeyPress = true;
            }

            if (CheckTextbox1Range() && e.KeyCode != Keys.Back)
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
            if (Textbox1NotEmpty() && Textbox2NotEmpty())
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
        
        private bool Textbox2NotEmpty()
        {
            return textBox2.Text != string.Empty;
        }

        private bool Textbox1NotEmpty()
        {
            return textBox1.Text != string.Empty;
        }

        private System.Drawing.Point SetLabelLocation()
        {
            return new System.Drawing.Point(Width / 2 - label1.Width / 2, 10);
        }

        private System.Drawing.Point SetButtonLocation()
        {
            return new System.Drawing.Point(Width / 2 - button1.Width / 2, 330);
        }

        private bool CheckTextbox1Range()
        {
            return textBox1.Text.Length >= 20;
        }
    }
}
