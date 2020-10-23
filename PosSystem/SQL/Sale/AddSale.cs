using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    internal class AddSale: SqlQueries
    {
        private readonly ListView listView1;
        private int index;

        public AddSale(ListView listView1, int index)
        {
            this.listView1 = listView1;
            this.index = index;
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = CreateCommandText();
            oleDbCommand.Parameters.AddWithValue("ItemID", listView1.Items[index].SubItems[2].Text);
            oleDbCommand.Parameters.AddWithValue("TotalPrice", listView1.Items[index].SubItems[3].Text);
            oleDbCommand.Parameters.AddWithValue("ReceiptDate", DateTime.Now.ToString("yyyy-MM-dd"));
            oleDbCommand.Parameters.AddWithValue("SaleQuantity", listView1.Items[index].SubItems[1].Text);
            oleDbCommand.Parameters.AddWithValue("WorkerID", UserDetailsVAR.Id.ToString());
            return oleDbCommand;
        }

        private string CreateCommandText()
        {
            return "INSERT INTO SALE (ItemID, TotalPrice, ReceiptDate, SaleQuantity, WorkerID )VALUES(?,?,?,?,?)";
        }
    }
}