using System;
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
            SetPanelLocation();
        }

        private void SetPanelLocation()
        {
            panel1.Location = ManageWorkerSetLocationCenter.CenterPanel1(Width, Height);
            panel2.Location = ManageWorkerSetLocationCenter.CenterPanel2(Width, Height);
        }

        private DockStyle GetDock()
        {
            return DockStyle.Fill;
        }

        private void Button7_Click(object sender, System.EventArgs e)
        {

        }

        private void Button4_Click(object sender, System.EventArgs e)
        {

        }
    }
}
