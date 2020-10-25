using System;
using System.Data.OleDb;

namespace PosSystem
{
    internal class AddToOrderDetails: SqlQueries
    {
        private readonly ManageItem manageItem;
        private readonly int index;

        public AddToOrderDetails(ManageItem manageItem, int index)
        {
            this.manageItem = manageItem;
            this.index = index;
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("OrderLine", index);
            oleDbCommand.Parameters.AddWithValue("Barcode", manageItem.listView1.Items[index].SubItems[0].Text);
            oleDbCommand.Parameters.AddWithValue("OrderQuantity", manageItem.listView1.Items[index].SubItems[1].Text); // CHANGE TO STRING 
            oleDbCommand.Parameters.AddWithValue("WorkerID", UserDetailsVAR.Id);
            return oleDbCommand;
        }


        private string GetCommandText()
        {
            return "INSERT INTO OrderDetails(OrderLine, Barcode, OrderQuantity, WorkerID) VALUES (?,?,?,?)";
        }
    }
}