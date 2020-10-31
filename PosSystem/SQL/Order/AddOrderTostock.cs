using System.Data.OleDb;

namespace PosSystem
{
    internal class AddOrderTostock: SqlQueries
    {
        private readonly string barcode;
        private readonly string quantity;
        public AddOrderTostock(string barcode, string quantity)
        {
            this.barcode = barcode;
            this.quantity = quantity;

            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = CreateCommandText();
            oleDbCommand.Parameters.AddWithValue("@Item", quantity);
            oleDbCommand.Parameters.AddWithValue("@ItemID", barcode);
            return oleDbCommand;
        }

        private string CreateCommandText()
        {
            return "UPDATE Stock SET StockQuantity=(StockQuantity+@Item) WHERE ItemID=@ItemID";
        }
    }
}