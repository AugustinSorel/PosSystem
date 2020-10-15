using System.Data.OleDb;

namespace PosSystem
{
    internal class SaveToStock: SqlQueries
    {
        private readonly string codeBar;
        private readonly string Quantity;

        public SaveToStock(string text, string Quantity)
        {
            codeBar = text;
            this.Quantity = Quantity;
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.Parameters.AddWithValue("ItemID", codeBar);
            oleDbCommand.Parameters.AddWithValue("StockQuantity", Quantity);
            oleDbCommand.CommandText = GetCommandText();
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "INSERT INTO Stock (ItemID, StockQuantity) VALUES (?,?)";
        }
    }
}