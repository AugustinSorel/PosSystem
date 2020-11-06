using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

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
            SetLocation();
            pictureBoxItem.Image = GetDefaultImage();
            SetCombboBox();
        }

        private void SetCombboBox()
        {
            new SetSupplierId(comboBox1);
            new SetCategoryId(comboBox2);
        }

        private static Bitmap GetDefaultImage()
        {
            return Properties.Resources.DefaultItem;
        }

        private void SetLocation()
        {
            panel1.Location = ManageStockSetCenterLocation.Panel1Center(panel1.Width);
            panel2.Location = ManageStockSetCenterLocation.Panel2Center(panel2.Width);
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
            if (TextboxesFilled() && ComboBoxFilled() && BarCodeUnique() && SupplierExists() && CategoryExists() && BarCodeLengthIs13() && CheckMinAndMax() && CheckIntegerInput())
            {
                groupBox1.Enabled = false;
                new AddProduct(this);
                new SaveToStock(TxtBoxBarCode.Text);
                new ManageStockClearControls(this);
            }
        }

        private bool ComboBoxFilled()
        {
            return StockCheckInput.CheckComboBoxFilled(groupBox1);
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

        private bool BarCodeLengthIs13()
        {
            return StockCheckInput.CheckBarCodeLenght(TxtBoxBarCode.Text);
        }

        private bool SupplierExists()
        {
            if (!ManageItemSupplier.CheckIfSupplierIDIsUnique(comboBox1.SelectedItem.ToString()) || comboBox1.SelectedItem.ToString() == "NO SUPPLIER") 
            { 
                MessageBox.Show("Supplier ID doesnt exists");
                return false;
            }
            else
                return true;
        }

        private bool CategoryExists()
        {
            if (comboBox2.SelectedItem.ToString() == "NO CATEGORY")
            {
                MessageBox.Show("Category ID doesnt exists");
                return false;
            }
            else
                return true;
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

        private void BtnDeleteCancel_Click(object sender, System.EventArgs e)
        {
            groupBox3.Enabled = false;
            txtDelete.Clear();
        }

        private void BtnDeleteEnable_Click(object sender, System.EventArgs e)
        {
            groupBox3.Enabled = true;
            txtDelete.Focus();
        }

        private void BtnDeleteDelete_Click(object sender, System.EventArgs e)
        {
            if (txtDelete.Text != string.Empty && WorkerIdExists() && WarningMessage())
            {
                new DeleteStockItem(txtDelete.Text);
                new DeleteItem(txtDelete.Text);
                groupBox3.Enabled = false;
                txtDelete.Clear();
            }
        }

        private bool WarningMessage()
        {
            return CheckDeleteItem.Check();
        }

        private bool WorkerIdExists()
        {
            return CheckIfItemBarCodeExists.Check(txtDelete.Text);
        }

        private void TxtCoef_TextChanged(object sender, EventArgs e)
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

        private void TxtBoxPurchacePrice_TextChanged(object sender, EventArgs e)
        {
            TxtCoef_TextChanged(sender, e);
        }

        private void BtnGenerateBarcode_Click(object sender, EventArgs e)
        {
            TxtBoxBarCode.Clear();
            Random random = new Random();

            for (int i = 0; i < 13; i++)
            {
                int digit = random.Next(0, 9);
                TxtBoxBarCode.Text += digit.ToString();

                if (!BarCodeUnique())
                    btnGenerateBarcode.PerformClick();
            }
        }

        private void TxtBoxBarCode_TextChanged(object sender, EventArgs e)
        {
            if (BarCodeGreaterThanZero())
            {
                BarcodeWriter barcodeWriter = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                pictureBoxBarCode.Image = barcodeWriter.Write(TxtBoxBarCode.Text);
            }
        }

        private bool BarCodeGreaterThanZero()
        {
            return TxtBoxBarCode.Text.Length > 0;
        }

        private void TxtBoxBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (CodeBarLengthInRange() && e.KeyCode != Keys.Back)
                e.SuppressKeyPress = true;
        }

        private bool CodeBarLengthInRange()
        {
            return TxtBoxBarCode.Text.Length >= 13;
        }
    }
}
