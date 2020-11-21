using System.Data.OleDb;

namespace PosSystem
{
    class Workers: SqlQueries
    {
        public static string GetNumberOfWorkers()
        {
            CheckConnectionClosed();
            return CreateCommand().ExecuteScalar().ToString();
        }

        private static void CheckConnectionClosed()
        {
            if (oleDbConnection.State == System.Data.ConnectionState.Closed)
                oleDbConnection.Open();
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