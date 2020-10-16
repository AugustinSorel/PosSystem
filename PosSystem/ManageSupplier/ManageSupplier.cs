using System;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class ManageSupplier : UserControl
    {
        public ManageSupplier()
        {
            InitializeComponent();
        }

        private void ManageSupplier_Load(object sender, System.EventArgs e)
        {
            Dock = GetFill();
            BringToFront();
            SetLocation();
        }

        private void SetLocation()
        {
            panel1.Location = ManageItemSetLocation.Panel1Center(panel1.Width);
            panel2.Location = ManageStockSetCenterLocation.Panel2Center(panel2.Width);
        }

        private static DockStyle GetFill()
        {
            return DockStyle.Fill;
        }

        private void BtnEnable_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = true;
            txtBoxName.Focus();
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = false;
            new ManageSupplierClearControls(this);
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = false;
            new SaveSupplier(this);
            new ManageSupplierClearControls(this);
        }

        private void BtnDeleteDelete_Click(object sender, EventArgs e)
        {
            if (SupplierIDExists() && WarningMessage())
            {
                groupBox3.Enabled = false;
                new DeleteSupplier(txtDelete.Text);
                new ManageSupplierClearControls(this);
                txtDelete.Clear();
            }
        }

        private bool WarningMessage()
        {
            return DisplayWarning.Message();
        }

        private bool SupplierIDExists()
        {
            return SupplierIdD.Exists(txtDelete.Text);
        }

        private void BtnDeleteEnable_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            txtDelete.Focus();
        }

        private void BtnDeleteCancel_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;
            txtDelete.Clear();
        }
    }
}
