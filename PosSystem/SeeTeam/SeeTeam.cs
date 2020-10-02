using System.Windows.Forms;

namespace PosSystem
{
    public partial class SeeTeam : UserControl
    {
        public SeeTeam()
        {
            InitializeComponent();
        }

        private void SeeTeam_Load(object sender, System.EventArgs e)
        {
            Dock = GetDock();
            BringToFront();
        }

        private DockStyle GetDock()
        {
            return DockStyle.Fill;
        }
    }
}
