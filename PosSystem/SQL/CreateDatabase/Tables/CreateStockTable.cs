using System.Data.OleDb;

namespace PosSystem
{
    class CreateStockTable: SqlQueries
    {
        public CreateStockTable()
        {
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommand();
            return oleDbCommand;
        }

        private string GetCommand()
        {
            return "CREATE TABLE Stock("
                + "ItemID AUTOINCREMENT,"
                + "StockQuantity NUMERIC,"
                + "PRIMARY KEY(ItemID)"
                + ")";
        }
    }
}
