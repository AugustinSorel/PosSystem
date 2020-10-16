using System;
using System.Data.OleDb;

namespace PosSystem
{
    internal class DeleteSupplier: SqlQueries
    {
        private string text;

        public DeleteSupplier(string text)
        {
            this.text = text;
            ExecuteCommand(CreateCommand());
            System.Windows.Forms.MessageBox.Show("Supplier Deleted successfully");
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("SupplierID", text);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "DELETE FROM Supplier WHERE SupplierID=@SupplierID";
        }
    }
}