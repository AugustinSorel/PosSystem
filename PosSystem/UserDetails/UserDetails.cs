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
        }

        private DockStyle GetFill()
        {
            return DockStyle.Fill;
        }
    }
}
