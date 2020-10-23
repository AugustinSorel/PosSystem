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
                + "ReceiptID AUTOINCREMENT,"
                + "itemID NUMERIC,"
                + "TotalPrice NUMERIC,"
                + "ReceiptDate DATE,"
                + "SaleQuantity NUMERIC,"
                + "WorkerID NUMERIC,"
                + "PRIMARY KEY(ReceiptID)"
                + ")";
        }
    }
}
