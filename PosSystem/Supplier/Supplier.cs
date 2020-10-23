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
            LoadData();
            SetLocation();
        }

        private void SetLocation()
        {
            panel1.Location = SupplierSetLocation.SetPanel1(panel1.Width);
            panel2.Location = SupplierSetLocation.SetPanel2(panel2.Width, panel2.Height);
            dataGridView1.Location = SupplierSetLocation.SetDataGridView(dataGridView1.Width, dataGridView1.Height);
        }

        private void LoadData()
        {
            new SupplierLoadDataGridView(dataGridView1);
            lblNumberOfItems.Text = dataGridView1.Rows.Count >= 1 ? GetSupplier.Number() : 1.ToString();
            SelectFirstRow();
        }

        private void SelectFirstRow()
        {
            if (dataGridView1.Rows.Count > 1)
                DataGridView1_CellClick(dataGridView1, new DataGridViewCellEventArgs(0, 0));
        }

        private static DockStyle GetFill()
        {
            return DockStyle.Fill;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new SupplierDisplayDetails(this);
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (TextBoxesFilled() && PhoneNumberCorrect())
            {
                new UpdaateSupplier(this);
                groupBox1.Enabled = false;
                LoadData();
            }
        }

        private bool TextBoxesFilled()
        {
            return SupplierCheckInput.TextBoxesFilled(groupBox1);
        }

        private bool PhoneNumberCorrect()
        {
            return SupplierCheckInput.PhoneNumber(textBoxPhone.Text);
        }

        private void BtnEnable_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = true;
            TxtBoxName.Focus();
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = false;
            new SupplierClearControls(this);
        }

        private void BtnSearchNameSearch_Click(object sender, System.EventArgs e)
        {
            new SupplierSearch(this);
            groupBox3.Enabled = false;
        }

        private void BtnSearchNameEnable_Click(object sender, System.EventArgs e)
        {
            groupBox3.Enabled = true;
            TxtBoxSearchName.Focus();
        }

        private void BtnSearchNameReset_Click(object sender, System.EventArgs e)
        {
            LoadData();
            groupBox3.Enabled = false;
        }

        private void EnableGroupBoxGroupBy_Click(object sender, System.EventArgs e)
        {
            groupBox4.Enabled = true;
        }

        private void ResetGroupBoxGroupBy_Click(object sender, System.EventArgs e)
        {
            groupBox4.Enabled = false;
        }

        private void BtnGroupByPrice_Click(object sender, System.EventArgs e)
        {
            new SupplierOrderById(dataGridView1);
        }

        private void BtnGroupName_Click(object sender, System.EventArgs e)
        {
            new SupplierOrderByName(dataGridView1);
        }
    }
}
