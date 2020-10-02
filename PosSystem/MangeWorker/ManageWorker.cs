using System.Windows.Forms;

namespace PosSystem
{
    public partial class ManageWorker : UserControl
    {
        public ManageWorker()
        {
            InitializeComponent();
        }

        private void AddWorker_Load(object sender, System.EventArgs e)
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
