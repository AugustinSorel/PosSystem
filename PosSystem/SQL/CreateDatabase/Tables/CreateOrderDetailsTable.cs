using System.Data.OleDb;

namespace PosSystem
{
    class CreateOrderDetailsTable: SqlQueries
    {
        public CreateOrderDetailsTable()
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
            return "CREATE TABLE OrderDetails("
                + "OrderID AUTOINCREMENT,"
                + "OrderNumber NUMERIC,"
                + "OrderLine NUMERIC,"
                + "ItemID NUMERIC,"
                + "OrderQuantity NUMERIC,"
                + "PRIMARY KEY(OrderID)"
                + ")";
        }
    }
}
