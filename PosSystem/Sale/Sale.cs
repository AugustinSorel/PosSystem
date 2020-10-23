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
            PrintReceipt();
            RemoveItemFromDB();
            listView1.Items.Clear();
        }

        private void PrintReceipt()
        {
            if (checkBoxPrintReceipt.Checked)
            {
                new CreateReceipt(listView1, UserDetailsVAR.Id.ToString(), DateTime.Now.ToString("yyyy-MM-dd"));
                checkBoxPrintReceipt.Checked = false;
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
    }
}
