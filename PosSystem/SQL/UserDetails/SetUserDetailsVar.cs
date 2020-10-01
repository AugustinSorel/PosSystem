using System;
using System.Data.OleDb;

namespace PosSystem
{
    class SetUserDetailsVar: SqlQueries
    {
        public string _Username;
        public string _Password;

        public SetUserDetailsVar(string username, string password)
        {
            _Username = username;
            _Password = password;

            OleDbDataReader dataReader = CreateCommand().ExecuteReader();
            GetIdAndAdmin(dataReader);
        }

        private void GetIdAndAdmin(OleDbDataReader oleDbDataReader)
        {
            try
            {
                while (oleDbDataReader.Read())
                {
                    UserDetailsVAR.Id = int.Parse(oleDbDataReader["WorkerID"].ToString());
                    UserDetailsVAR.Admin = bool.Parse(oleDbDataReader["Admin"].ToString());
                }                
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Either WorkerID is null or Admin is null for the username: " + _Username);
            }
        }

        private OleDbCommand CreateCommand()
        {
            OpenOleDbConnection();
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("@WorkerID", _Username);
            oleDbCommand.Parameters.AddWithValue("@password", _Password);
            return oleDbCommand;
        }

        private static string GetCommandText()
        {
            return "SELECT * FROM WorkerSecurity WHERE Username=@WorkerID AND Password=@password";
        }
    }
}
