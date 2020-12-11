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
            SetCombboBox();
        }

        private void SetCombboBox()
        {
            new SetSupplierId(comboBox1);
            new SetCategoryId(comboBox2);
        }

        private void SetControlsLocation()
        {
            panel1.Location = StockSetontrolsLocationCenter.Panel1(panel1.Width);
            panel2.Location = StockSetontrolsLocationCenter.SetPanel2(panel2.Width, panel2.Height);
            panel3.Location = StockSetontrolsLocationCenter.DataGridView(panel3.Width);
        }

        private void LoadData()
        {
            new LoadDataGridViewStock(dataGridView1);
            lblNumberOfItems.Text = ShowNumberOfItems.Display();
            dataGridView1.Update();
            dataGridView1.Refresh();
            ShowTables();
        }

        private void ShowTables()
        {
            dataGridView1.Columns["ItemID"].Visible = true;
            dataGridView1.Columns["Description"].Visible = true;
            dataGridView1.Columns["SupplierID"].Visible = true;
            dataGridView1.Columns["CategoryID"].Visible = true;
            dataGridView1.Columns["PurchasePrice"].Visible = true;
            dataGridView1.Columns["Coefficient"].Visible = true;
            dataGridView1.Columns["VatID"].Visible = true;
            dataGridView1.Columns["ProductPhoto"].Visible = true;
            dataGridView1.Columns["StockMin"].Visible = true;
            dataGridView1.Columns["StockMax"].Visible = true;
        }

        private DockStyle GetFillDock()
        {
            return DockStyle.Fill;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns.Count > 4)
            {
                new DisplayStock(this);
                new DisplayItem(this);
            }
        }

        private void BtnEnable_Click_1(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            txtboxQuantity.Focus();
        }

        private void BtnSave_Click_1(object sender, System.EventArgs e)
        {
            if (SupplierIdExists() && TextboxesFilled() && CheckMinAndMax() && CheckIntegerInput() && CheckCategory() && CurrentStockLessThanMaxStock())
            {
                new UpdateItemDetails(this);
                new UpdateStockQuantity(this);
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                LoadData();
            }
        }

        private bool CurrentStockLessThanMaxStock()
        {
            if (int.Parse(textBoxStockMax.Text) >= int.Parse(txtboxQuantity.Text))
                return true;
            else
            {
                MessageBox.Show("Current Stock is higher than stock max", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool CheckCategory()
        {
            if (comboBox2.SelectedItem.ToString() == "NO CATEGORY")
            {
                MessageBox.Show("Category ID doesnt exists");
                return false;
            }
            else
                return true;
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
            if (!ManageItemSupplier.CheckIfSupplierIDIsUnique(comboBox1.SelectedItem.ToString()) || comboBox1.SelectedItem.ToString() == "NO SUPPLIER")
            {
                MessageBox.Show("Supplier ID doesnt exists");
                return false;
            }
            else
                return true;
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
            try
            {
                new OrderByItemPrice(dataGridView1);
            }
            catch (Exception)
            {
                ResetGroupBoxGroupBy.PerformClick();
                BtnGroupByPrice.PerformClick();
            }
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Excel.DataGridViewSaveTOExcel(dataGridView1);
        }
    }
}
