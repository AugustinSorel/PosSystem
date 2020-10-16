using System.Windows.Forms;

namespace PosSystem
{
    public partial class Supplier : UserControl
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, System.EventArgs e)
        {
            Dock = GetFill();
            BringToFront();
        }

        private static DockStyle GetFill()
        {
            return DockStyle.Fill;
        }
    }
}
