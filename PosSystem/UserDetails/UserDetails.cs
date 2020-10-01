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
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = false;
            LoadData();
        }

        private void Button5_Click(object sender, System.EventArgs e)
        {

        }

        private void Button6_Click(object sender, System.EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void Button7_Click(object sender, System.EventArgs e)
        {
            new SaveUserSecurity(this);
        }
    }
}
