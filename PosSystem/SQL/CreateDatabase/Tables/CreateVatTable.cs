using System.Data.OleDb;

namespace PosSystem
{
    class CreateVatTable : SqlQueries
    {
        public CreateVatTable()
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
            return "CREATE TABLE Vat("
                + "VatID AUTOINCREMENT,"
                + "VatRate DOUBLE,"
                + "PRIMARY KEY(VatID)"
                + ")";
        }
    }
}
