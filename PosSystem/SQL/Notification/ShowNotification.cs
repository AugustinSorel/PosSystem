using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    internal class ShowNotification: SqlQueries
    {
        private readonly ListView listView1;
        private readonly OleDbDataReader oleDbDataReader;
        private int stockMin;
        private int quantity;
        private readonly int range;
        private string itemID;

        public ShowNotification(ListView listView1, Label label1, string stringRange)
        {
            this.listView1 = listView1;
            range = int.Parse(stringRange);
            oleDbDataReader = GetCommand().ExecuteReader(CommandBehavior.SingleResult);
            ClearList();
            ItterateDB();
            label1.Text = GetNumberOfItems();
        }

        private void ClearList()
        {
            listView1.Items.Clear();
        }

        private string GetNumberOfItems()
        {
            int NmbRows = GetNumberOfRowsInListView();
             return "Number of items nearly out of stock: " + NmbRows.ToString();
        }

        private int GetNumberOfRowsInListView()
        {
            int NmbRows = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
                NmbRows++;
            return NmbRows;
        }

        private void ItterateDB()
        {
            while (oleDbDataReader.Read())
            {
                quantity = GetStockQuantity();
                stockMin = GetStockMin();
                itemID = GetItemID();

                if (CurrentStockNearlyOutOfStockMin())
                    ShowItemInListView();
            }
        }

        private void ShowItemInListView()
        {
            ListViewItem listViewItem = new ListViewItem(itemID);
            listViewItem.SubItems.Add(quantity.ToString());
            listViewItem.SubItems.Add(stockMin.ToString());
            listView1.Items.Add(listViewItem);
        }

        private bool CurrentStockNearlyOutOfStockMin()
        {
            return quantity - range <= stockMin;
        }

        private int GetStockQuantity()
        {
            return int.Parse(oleDbDataReader["StockQuantity"].ToString());
        }

        private int GetStockMin()
        {
            return int.Parse(oleDbDataReader["StockMin"].ToString());
        }

        private string GetItemID()
        {
            return (oleDbDataReader["ItemID"].ToString());
        }

        private static OleDbCommand GetCommand()
        {
            OleDbCommand cmd = oleDbConnection.CreateCommand();
            cmd.CommandText = GetCommandText();

            if (oleDbConnection.State == ConnectionState.Closed)
                oleDbConnection.Open();

            return cmd;
        }

        private static string GetCommandText()
        {
            return "Select Items.ItemID, Stock.StockQuantity, Items.StockMin from Stock INNER JOIN Items ON Stock.ItemID = Items.Barcode";
        }
    }
}