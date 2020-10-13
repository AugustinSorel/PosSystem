using System.Data.OleDb;

namespace PosSystem
{
    class Workers: SqlQueries
    {
        public static string GetNumberOfWorkers()
        {
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
            return "SELECT COUNT(*) FROM WorkerDetails";
        }
    }
}