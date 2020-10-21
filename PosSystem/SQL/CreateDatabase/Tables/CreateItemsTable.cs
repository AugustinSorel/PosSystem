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
                + "CategoryID NUMERIC,"
                + "PurchasePrice DOUBLE,"
                + "Coefficient DOUBLE,"
                + "SellingPrice DOUBLE,"
                + "VatID NUMERIC,"
                + "BarCode CHAR(13),"
                + "ProductPhoto OLEOBJECT,"
                + "StockMin NUMERIC,"
                + "StockMax NUMERIC,"
                + "PRIMARY KEY(ItemID)"
                + ")";
        }
    }
}
