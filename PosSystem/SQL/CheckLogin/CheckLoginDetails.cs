using System;
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
            GetIdAndAdmin(dataReader);
            return dataReader;
        }

        private static void GetIdAndAdmin(OleDbDataReader oleDbDataReader)
        {
            try
            {
                int s = -1;
                bool b = false;
                while (oleDbDataReader.Read())
                {
                    s = int.Parse(oleDbDataReader["WorkerID"].ToString());
                    b = bool.Parse(oleDbDataReader["Admin"].ToString());
                }
                UserDetailsVAR.Id = s;
                UserDetailsVAR.Admin = b;
            }
            catch (Exception)
            {
            }
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
