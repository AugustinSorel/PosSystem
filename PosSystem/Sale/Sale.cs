using System;
using System.Drawing;
using System.Drawing.Printing;
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
            ClearItemsInList();
            listView1.Items.Clear();
        }

        private void ClearItemsInList()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
                new RemoveStock(listView1.Items[i].SubItems[0].Text, listView1.Items[i].SubItems[1].Text);

            lblDescriptionDisplay.Text = "0 £";
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

        private void Button3_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;         
            printDocument.PrintPage += new PrintPageEventHandler(CreateReceipt); 

            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
                printDocument.Print();
        }

        public void CreateReceipt(object sender, PrintPageEventArgs e)
        {
            float cash = 50; // Change this
            float change = 0.00f;

            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12); 

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString(" Toy Shop Shop Test", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            string top = "Item CodeBar".PadRight(15) + "Quantity".PadRight(15) + "Price";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; 
            graphic.DrawString("-----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; 

            float totalprice = 0.00f;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string productBarCode = listView1.Items[i].SubItems[0].Text;
                string quantity = listView1.Items[i].SubItems[1].Text;
                float productPrice = float.Parse(listView1.Items[i].SubItems[3].Text);

                totalprice += productPrice;

                string productLine = productBarCode;

                graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(quantity, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(productPrice.ToString(), font, new SolidBrush(Color.Red), startX + 325, startY + offset);

                offset = offset + (int)fontHeight + 5; //make the spacing consistent

            }

            change = (cash - totalprice);

            offset = offset + 20; 

            graphic.DrawString("Total to pay ".PadRight(30) + String.Format("{0:c}", totalprice), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 30; 
            graphic.DrawString("CASH ".PadRight(30) + String.Format("{0:c}", cash), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("CHANGE ".PadRight(30) + String.Format("{0:c}", change), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 30; 
            graphic.DrawString("     Thank-you for your custom,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("       please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);

        }
    }
}
