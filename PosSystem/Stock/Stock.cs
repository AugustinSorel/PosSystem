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
            panel2.Location = StockSetontrolsLocationCenter.SetPanel2(panel2.Width, panel2.Height);
            dataGridView1.Location = StockSetontrolsLocationCenter.DataGridView(dataGridView1.Width);
        }

        private void LoadData()
        {
            new LoadDataGridViewStock(dataGridView1);
            lblNumberOfItems.Text = ShowNumberOfItems.Display();
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
            if (SupplierIdExists() && TextboxesFilled() && CheckMinAndMax() && CheckIntegerInput())
            {
                new UpdateItemDetails(this);
                new UpdateStockQuantity(this);
                LoadData();
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }
        }

        private bool TextboxesFilled()
        {
            return StockCheckInput.CheckTextboxesFilled(groupBox1);
        }

        private bool CheckMinAndMax()
        {
            return StockCheckInput.CheckMinAndMax(textBoxStockMax.Text, textBoxStockMin.Text);
        }

        private bool CheckIntegerInput()
        {
            return StockCheckInput.CheckInteger(TxtBoxPurchacePrice.Text) && StockCheckInput.CheckInteger(txtCoef.Text)
                && StockCheckInput.CheckInteger(textBoxStockMin.Text) && StockCheckInput.CheckInteger(textBoxStockMax.Text);
        }

        private bool SupplierIdExists()
        {
            return ManageItemSupplier.CheckIfSupplierIDIsUnique(TxtBoxSupplierID.Text);
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

        private void BtnSearchNameReset_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;
            TxtBoxSearchName.Clear();
            LoadData();
        }

        private void BtnSearchNameEnable_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            TxtBoxSearchName.Focus();
        }

        private void BtnSearchNameSearch_Click(object sender, EventArgs e)
        {
            new SearchItemByCodeBar(this);
        }

        private void EnableGroupBoxGroupBy_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;
        }

        private void ResetGroupBoxGroupBy_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = false;
            LoadData();
        }

        private void BtnGroupStockQuantity_Click(object sender, EventArgs e)
        {
            new OrderByItemQuantity(dataGridView1);
        }

        private void BtnGroupByPrice_Click(object sender, EventArgs e)
        {
            new OrderByItemPrice(dataGridView1);
        }

        private void TxtBoxPurchacePrice_TextChanged(object sender, EventArgs e)
        {
            if (StockCheckInput.CheckInteger(TxtBoxPurchacePrice.Text))
            {
                double purchasePrice;
                double coef;
                purchasePrice = TxtBoxPurchacePrice.Text == string.Empty ? 0 : double.Parse(TxtBoxPurchacePrice.Text);
                coef = txtCoef.Text == string.Empty ? 0 : int.Parse(txtCoef.Text);
                lblFinalPrice.Text = (purchasePrice * coef).ToString();
            }
        }

        private void TxtCoef_TextChanged(object sender, EventArgs e)
        {
            TxtBoxPurchacePrice_TextChanged(sender, e);
        }
    }
}
