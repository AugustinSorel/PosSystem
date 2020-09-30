using System.Data;
using System.Data.OleDb;

namespace PosSystem
{
    class CheckLoginDetails: SqlQueries
    {
        private static string _Username;
        private static string _Password;

        public static bool LoginDetailsIsCorrect(string username, string password) 
        {
            _Username = username;
            _Password = password;
            return CreateDataReader().HasRows;
        }

        private static OleDbDataReader CreateDataReader()
        {
            OleDbDataReader dataReader = CreateCommand().ExecuteReader();
            return dataReader;
        }

        private static OleDbCommand CreateCommand()
        {
            OpenConnection();
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("@userid", _Username);
            oleDbCommand.Parameters.AddWithValue("@password", _Password);
            return oleDbCommand;
        }

        private static void OpenConnection()
        {
            if (oleDbConnection.State == ConnectionState.Closed)
                oleDbConnection.Open();
        }

        private static string GetCommandText()
        {
            return "SELECT * FROM WorkerSecurity WHERE Username=@userid AND Password=@password";
        }
    }
}
