using System.Data.OleDb;

namespace PosSystem
{
    class CreateSupplierTable: SqlQueries
    {
        public CreateSupplierTable()
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
            return "CREATE TABLE Supplier("
                + "SupplierID AUTOINCREMENT,"
                + "SupplierName CHAR(30),"
                + "SupplierAddress CHAR(30),"
                + "PhoneNumber NUMERIC,"
                + "Mail CHAR(50),"
                + "PRIMARY KEY(SupplierID)"
                + ")";
        }
    }
}
