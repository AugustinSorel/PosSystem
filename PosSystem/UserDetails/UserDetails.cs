using System;
using System.Drawing;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class UserDetails : UserControl
    {
        public UserDetails()
        {
            InitializeComponent();
        }

        private void UserDetails_Load(object sender, System.EventArgs e)
        {
            Dock = GetFill();
            panel1.Location = UserDetailsSetLocation.CenterGroupBox(panel1.Width, panel1.Height);
            BringToFront();
            LoadData();
        }

        private void LoadData()
        {
            new ShowUserDetails(this);
            new ShowUserSecurity(this);
        }

        private DockStyle GetFill()
        {
            return DockStyle.Fill;
        }

        private void Button3_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = true;
            textBox1.Focus();
        }

        private void Button4_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            new SaveUserDetails(this);
            MessageBox.Show("Account saved successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            groupBox1.Enabled = false;
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = false;
            LoadData();
        }

        private void Button5_Click(object sender, System.EventArgs e)
        {
            groupBox2.Enabled = false;
            LoadData();
        }

        private void Button6_Click(object sender, System.EventArgs e)
        {
            groupBox2.Enabled = true;
            textBox5.Focus();
        }

        private void Button7_Click(object sender, System.EventArgs e)
        {
            if (UsernameNotTaken())
                new SaveUserSecurityDetails(this);
        }

        private bool UsernameNotTaken()
        {
            return !UserDerailsCheckIfUserNameIsTaken.CheckUserName(this);
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox6.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button7.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}

