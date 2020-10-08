using System.Data.OleDb;

namespace PosSystem
{
    class CreateSaleTable: SqlQueries
    {
        public CreateSaleTable()
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
            return "CREATE TABLE Sale("
                + "ItemID AUTOINCREMENT,"
                + "SaleQuantity NUMERIC,"
                + "WorkerID NUMERIC,"
                + "CustomerID NUMERIC,"
                + "PRIMARY KEY(ItemID)"
                + ")";
        }
    }
}
