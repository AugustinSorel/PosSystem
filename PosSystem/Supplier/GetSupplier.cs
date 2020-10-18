using System.Data.OleDb;

namespace PosSystem
{
    internal class GetSupplier: SqlQueries
    {
        public static string Number()
        {
            oleDbConnection.Open();
            return CreateCommand().ExecuteScalar().ToString();
        }

        private static OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            return oleDbCommand;
        }

        private static string GetCommandText()
        {
            return "SELECT COUNT(*) FROM Supplier";
        }
    }
}