using System.Windows.Forms;

namespace PosSystem
{
    public partial class AddWorker : UserControl
    {
        public AddWorker()
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
