using System;
using System.Data.OleDb;

namespace PosSystem
{
    internal class InsertOrderDetails: SqlQueries
    {
        private readonly RecordForOrder recordForOrder;

        public InsertOrderDetails(RecordForOrder recordForOrder)
        {
            this.recordForOrder = recordForOrder;
            System.Windows.Forms.MessageBox.Show(recordForOrder.OrderID.ToString());
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("OrderID", recordForOrder.OrderID);
            oleDbCommand.Parameters.AddWithValue("OrderDate", DateTime.Now.ToString("yyyy-MM-dd"));
            oleDbCommand.Parameters.AddWithValue("OrderLine", recordForOrder.Index);
            oleDbCommand.Parameters.AddWithValue("ItemID", recordForOrder.ItemID);
            oleDbCommand.Parameters.AddWithValue("OrderQuantity", recordForOrder.Quantity);
            oleDbCommand.Parameters.AddWithValue("WorkerID", UserDetailsVAR.Id);
            oleDbCommand.Parameters.AddWithValue("Price", recordForOrder.Price);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "INSERT INTO orderDetails (OrderID, OrderDate, OrderLine, ItemID, OrderQuantity, WorkerID, Price) VALUES (?,?,?,?,?,?,?)";
        }
    }
}