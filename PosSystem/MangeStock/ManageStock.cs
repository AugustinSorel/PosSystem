using System.Drawing;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class ManageStock : UserControl
    {
        public ManageStock()
        {
            InitializeComponent();
        }

        private void ManageStock_Load(object sender, System.EventArgs e)
        {
            Dock = GetFill();
            BringToFront();
            panel1.Location = ManageStockSetCenterLocation.Panel1Center(panel1.Width);
            pictureBoxItem.Image = Properties.Resources.DefaultItem;
        }

        private static DockStyle GetFill()
        {
            return DockStyle.Fill;
        }

        private void BtnEnable_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = true;
            TxtBoxDescrption.Focus();
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = false;
            new AddProduct(this);
            new ManageStockClearControls(this);
        }

        private void BtnBrowse_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    pictureBoxItem.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
