using System.Data.OleDb;

namespace PosSystem
{
    internal class RemoveStock : SqlQueries
    {
        private readonly string barCode;
        private readonly string quantity;

        public RemoveStock(string barCode, string quantity)
        {
            this.barCode = barCode;
            this.quantity = quantity;
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = CreateCommandText();
            oleDbCommand.Parameters.AddWithValue("@Item", quantity);
            oleDbCommand.Parameters.AddWithValue("@ItemID", barCode);
            return oleDbCommand;
        }

        private string CreateCommandText()
        {
            return "UPDATE Stock SET StockQuantity=(StockQuantity-@Item) WHERE ItemID=@ItemID";
        }
    }
}
