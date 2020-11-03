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
            TxtboxName.Focus();
        }

        private void Button4_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    UserPicture.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            if (TextboxesFilledDetails() && AgeCorrect())
            {
                new SaveUserDetails(this);
                MessageBox.Show("Account saved successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
            }
        }

        private bool TextboxesFilledDetails()
        {
            return UserDetailsCheckInput.TextboxesFilled(groupBox1);
        }

        private bool AgeCorrect()
        {
            return UserDetailsCheckInput.Age(TxtboxAge.Text);
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
            TxtboxUsername.Focus();
        }

        private void Button7_Click(object sender, System.EventArgs e)
        {
            if (UsernameNotTaken() && TextboxesFilledSecurity())
                new SaveUserSecurityDetails(this);
        }

        private bool TextboxesFilledSecurity()
        {
            return UserDetailsCheckInput.TextboxesFilled(groupBox2);
        }

        private bool UsernameNotTaken()
        {
            return !UserDerailsCheckIfUserNameIsTaken.CheckUserName(this);
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtboxSurname.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtboxAge.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtboxGender.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnUserDetailsSave.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtboxPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnUserSecuritySave.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}

