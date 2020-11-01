using System;
using System.Data.OleDb;

namespace PosSystem
{
    internal class InsertOrderDetails: SqlQueries
    {
        private readonly string itemID;
        private readonly string quantity;
        private readonly string price;
        private readonly int index;
        private readonly int orderID;

        public InsertOrderDetails(string itemID, string quantity, string price, int index, int orderID)
        {
            this.itemID = itemID;
            this.quantity = quantity;
            this.price = price;
            this.index = index;
            this.orderID = orderID;

            System.Windows.Forms.MessageBox.Show(orderID.ToString());
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("OrderID", orderID);
            oleDbCommand.Parameters.AddWithValue("OrderDate", DateTime.Now.ToString("yyyy-MM-dd"));
            oleDbCommand.Parameters.AddWithValue("OrderLine", index);
            oleDbCommand.Parameters.AddWithValue("ItemID", itemID);
            oleDbCommand.Parameters.AddWithValue("OrderQuantity", quantity);
            oleDbCommand.Parameters.AddWithValue("WorkerID", UserDetailsVAR.Id);
            oleDbCommand.Parameters.AddWithValue("Price", price);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "INSERT INTO orderDetails (OrderID, OrderDate, OrderLine, ItemID, OrderQuantity, WorkerID, Price) VALUES (?,?,?,?,?,?,?)";
        }
    }
}