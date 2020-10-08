using System.Data.OleDb;

namespace PosSystem
{
    class CreateItemsTable: SqlQueries
    {
        public CreateItemsTable()
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
            return "CREATE TABLE Items("
                + "ItemID AUTOINCREMENT,"
                + "Description CHAR(255),"
                + "SupplierID NUMERIC,"
                + "BarCode NUMERIC,"
                + "UnitPrice DOUBLE,"
                + "ProductPhoto OLEOBJECT,"
                + "StockMin NUMERIC,"
                + "StockMax NUMERIC,"
                + "PRIMARY KEY(ItemID)"
                + ")";
        }
    }
}
