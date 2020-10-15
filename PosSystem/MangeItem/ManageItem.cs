using System.Drawing;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class ManageItem : UserControl
    {
        public ManageItem()
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
            groupBox2.Enabled = true;
            TxtBoxDescrption.Focus();
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            txtboxQuantity.Text = 0.ToString();
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (BarCodeUnique())
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                new AddProduct(this);
                new SaveToStock(TxtBoxBarCode.Text, txtboxQuantity.Text);
                new ManageStockClearControls(this);
            }
        }

        private bool BarCodeUnique()
        {
            return !ManageItemBarCode.CheckIfBarCodeIsUnique(this);
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
