using System;
using System.Data.OleDb;
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
            new SaleDisplayItem(this);

            ListViewItem listViewItem = new ListViewItem(textBox1.Text);


            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string codeBar = listView1.Items[i].SubItems[0].Text;
                int quantity = int.Parse(listView1.Items[i].SubItems[1].Text);

                if (textBox1.Text == codeBar)
                {
                    quantity++;
                    listView1.Items[i].SubItems[1].Text = quantity.ToString();
                    return;
                }
            }

            listViewItem.SubItems.Add("1");
            listViewItem.SubItems.Add(lblItemIDDisplay.Text);
            listView1.Items.Add(listViewItem);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                new RemoveStock(listView1.Items[i].SubItems[0].Text, listView1.Items[i].SubItems[1].Text);
            }
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            textBox1.Text =listView1.SelectedItems[0].SubItems[0].Text;
            new SaleDisplayItem(this);
        }
    }

    internal class RemoveStock: SqlQueries
    {
        private readonly string BarCode;
        private readonly string Quantity;

        public RemoveStock(string ItemID, string Quantity)
        {
            this.BarCode = ItemID;
            this.Quantity = Quantity;
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = CreateCommandText();
            oleDbCommand.Parameters.AddWithValue("@Item", Quantity);
            oleDbCommand.Parameters.AddWithValue("@ItemID", BarCode);
            return oleDbCommand;
        }

        private string CreateCommandText()
        {
            return "UPDATE Stock SET StockQuantity=(StockQuantity-@Item) WHERE ItemID=@ItemID";
        }
    }
}
