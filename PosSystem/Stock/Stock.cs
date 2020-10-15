using System.Windows.Forms;

namespace PosSystem
{
    public partial class Stock : UserControl
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, System.EventArgs e)
        {
            Dock = GetFillDock();
            BringToFront();
            SetControlsLocation();
            LoadData();
        }

        private void SetControlsLocation()
        {
            panel1.Location = StockSetontrolsLocationCenter.Panel1(panel1.Width);
            dataGridView1.Location = StockSetontrolsLocationCenter.DataGridView(dataGridView1.Width);
        }

        private void LoadData()
        {
            new LoadDataGridViewStock(dataGridView1);
        }

        private DockStyle GetFillDock()
        {
            return DockStyle.Fill;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new DisplayStock(this);
        }

        private void BtnEnable_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = true;
            txtboxQuantity.Focus();
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = false;
        }
    }
}
