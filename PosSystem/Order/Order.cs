using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, System.EventArgs e)
        {
            base.Dock = GetFill();
            BringToFront();
            SetLocation();
            DisplayLabels();
            SetComboBoxes();
        }

        private void SetComboBoxes()
        {
            new SetOrderQuantityComboBox(comboBox1);
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

        private void SetLocation()
        {
            panel1.Location = OrderLocation.SetPanel1(panel1.Width);
            panel2.Location = OrderLocation.SetPanel2(panel2.Width);
            label1.Location = OrderLocation.FinaPrice();
            panel3.Location = OrderLocation.Panel3(panel3.Width);
            groupBox2.Location = OrderLocation.GroupBox2(groupBox2.Width);
        }

        private static DockStyle GetFill()
        {
            return DockStyle.Fill;
        }

        private void BtnEnable_Click(object sender, System.EventArgs e)
        {
            groupBox1.Enabled = true;
            comboBox1.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            textBox1.Text = 0.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CombpBoxNotEmpty() && CombpBoxHasData())
            {
                DisplayItem();
                new InserOrderToList(this);
                ResetInputQuantity();
            }
        }

        private void ResetInputQuantity()
        {
            textBox1.Text = 1.ToString();
        }

        private bool CombpBoxNotEmpty()
        {
            return comboBox1.Text != string.Empty;
        }

        private bool CombpBoxHasData()
        {
            return comboBox1.Text != "NO ITEM" && comboBox1.Text != 0.ToString();  
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayItem();
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox1.FindString(listView1.SelectedItems[0].SubItems[0].Text);
            DisplayItem();
        }

        private void DisplayItem()
        {
            new OrderDisplayItem(this);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddToStock();
            InsertOrderDetails();
            ClearList();
            ClearPrice();
        }

        private void InsertOrderDetails()
        {
            int orderID = GetOrderID.GetHigherOrder();
            List<RecordForOrder> recordForOrder = new List<RecordForOrder>();

            recordForOrder.Add();

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                new InsertOrderDetails(listView1.Items[i].SubItems[0].Text, listView1.Items[i].SubItems[1].Text, listView1.Items[i].SubItems[2].Text, i, orderID);
            }
        }

        private void ClearPrice()
        {
            label1.Text = "Final Price:  0 £";
        }

        private void ClearList()
        {
            listView1.Items.Clear();
        }

        private void AddToStock()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
                new AddOrderTostock(listView1.Items[i].SubItems[0].Text, listView1.Items[i].SubItems[1].Text);
        }
    }
}
