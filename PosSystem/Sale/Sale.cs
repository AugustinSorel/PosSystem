using System;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class Sale : UserControl
    {
        public Sale()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, System.EventArgs e)
        {
            Dock = GetFill();
            BringToFront();
            DisplayLabels();
            FocusCodeBarTextBox();
            SetLocation();
        }

        private void SetLocation()
        {
            groupBox1.Location = SaleSetLocation.GroupBox1(groupBox1.Width);
            groupBox2.Location = SaleSetLocation.GroupBox2(groupBox2.Width);
            panel1.Location = SaleSetLocation.FinaPrice();
            panel2.Location = SaleSetLocation.Panel2(panel2.Width);
            groupBox3.Location = SaleSetLocation.GroupBox3(groupBox3.Width);
            groupBox4.Location = SaleSetLocation.GroupBox4(groupBox4.Width);
        }

        private void FocusCodeBarTextBox()
        {
            textBox1.Focus();
        }

        private void DisplayLabels()
        {
            lblDate.Text = GetDate();
            LblWorkerID.Text = GetWorkerID();
        }

        private static string GetWorkerID()
        {
            return "Worker ID: " + UserDetailsVAR.Id.ToString();
        }

        private static string GetDate()
        {
            return "Date: " + DateTime.Now.ToString("yyyy-MM-dd");
        }

        private static DockStyle GetFill()
        {
            return DockStyle.Fill;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (BarCodeExists() && ItemIsInStock())
            {
                new SaleDisplayItem(this);
                new AddItemToList(this);
            }
        }

        private bool ItemIsInStock()
        {
            return CheckItemInStock.CheckIfEnoughStock(textBox1.Text);
        }

        private bool BarCodeExists()
        {
            return CheckIfItemBarCodeExists.Check(textBox1.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (CheckPaymentMethod())
            {
                PrintReceipt();
                RemoveItemFromDB();
                AddToSale();
                ClearControls();
            }
        }

        private void ClearControls()
        {
            listView1.Items.Clear();
            textBox2.Clear();
            lblDisplayChange.Text = "0 £";
        }

        private bool CheckPaymentMethod()
        {
            return radioButton2.Checked || CheckCashInput();
        }

        private bool CheckCashInput() 
        {
            return SaleCheckInput.CheckCashInput(this);
        }

        private void AddToSale()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
                new AddSale(listView1, i);
        }

        private void PrintReceipt()
        {
            if (checkBoxPrintReceipt.Checked)
            {
                new CreateReceipt(listView1, UserDetailsVAR.Id.ToString(), DateTime.Now.ToString("yyyy-MM-dd"), radioButton1, textBox2, lblDisplayChange);
                checkBoxPrintReceipt.Checked = false;
            }

            if (checkBoxSaveToExcel.Checked)
            {
                Excel.ListViewSaveToExcel(listView1);
            }
        }

        private void RemoveItemFromDB()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
                new RemoveStock(listView1.Items[i].SubItems[0].Text, listView1.Items[i].SubItems[1].Text);

            lblDisplayFinalPrice.Text = "0 £";
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            textBox1.Text =listView1.SelectedItems[0].SubItems[0].Text;
            new SaleDisplayItem(this);
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Length == 13 && e.KeyCode != Keys.Back)
                button1.PerformClick();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = radioButton1.Checked;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
                return;

            if (SaleCheckInput.ChcekTextChangeCash(this))
            {
                double change = -(double.Parse(lblDisplayFinalPrice.Text.Trim('£')) - double.Parse(textBox2.Text));
                lblDisplayChange.Text = change.ToString() + " £";

            }
        }
    }
}
