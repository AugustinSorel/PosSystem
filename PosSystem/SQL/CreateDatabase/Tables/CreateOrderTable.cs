using System.Data.OleDb;

namespace PosSystem
{
    class CreateOrderTable: SqlQueries
    {
        public CreateOrderTable()
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
            return "CREATE TABLE [Order]("
                + "OrderID AUTOINCREMENT,"
                + "WorkerID NUMERIC,"
                + "PRIMARY KEY(OrderID)"
                + ")";
        }
    }
}
