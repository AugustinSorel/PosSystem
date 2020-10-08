using System.Data.OleDb;

namespace PosSystem
{
    class CreateCustomerTable: SqlQueries
    {
        public CreateCustomerTable()
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
            return "CREATE TABLE Customer("
                + "CustomerID AUTOINCREMENT,"
                + "CustomerName CHAR(30),"
                + "CustomerAge NUMERIC,"
                + "PRIMARY KEY(CustomerID)"
                + ")";
        }
    }
}
