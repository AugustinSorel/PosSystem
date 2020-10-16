using System.Data.OleDb;

namespace PosSystem
{
    internal class DeleteStockItem: SqlQueries
    {
        private readonly string CodeBar;

        public DeleteStockItem(string CodeBar)
        {
            this.CodeBar = CodeBar;
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("CodeBar", CodeBar);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "DELETE FROM Stock WHERE ItemID=@CodeBar";
        }
    }
}