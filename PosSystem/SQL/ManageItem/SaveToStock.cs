using System.Data.OleDb;

namespace PosSystem
{
    internal class SaveToStock: SqlQueries
    {
        private readonly string codeBar;

        public SaveToStock(string text)
        {
            codeBar = text;
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.Parameters.AddWithValue("ItemID", codeBar);
            oleDbCommand.Parameters.AddWithValue("StockQuantity", 0);
            oleDbCommand.CommandText = GetCommandText();
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "INSERT INTO Stock (ItemID, StockQuantity) VALUES (?,?)";
        }
    }
}