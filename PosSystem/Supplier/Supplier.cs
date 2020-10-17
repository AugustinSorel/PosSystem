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
            new UpdaateSupplier(this);
            groupBox1.Enabled = false;
            LoadData();
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
    }
}
