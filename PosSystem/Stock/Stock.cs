using System;
using System.Drawing;
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
            new DisplayItem(this);
        }

        private void BtnEnable_Click_1(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            txtboxQuantity.Focus();
        }

        private void BtnSave_Click_1(object sender, System.EventArgs e)
        {
            new UpdateItemDetails(this);
            new UpdateStockQuantity(this);
            LoadData();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void BtnCancel_Click_1(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            ClearControls();
        }

        private void ClearControls()
        {
            new StockClearControls(groupBox1, groupBox2);
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    pictureBoxItem.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
