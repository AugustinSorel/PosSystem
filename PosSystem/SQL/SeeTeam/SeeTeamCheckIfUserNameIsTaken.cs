using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    class SeeTeamCheckIfUserNameIsTaken: SqlQueries
    {
        private static string _Username;

        public static bool CheckUserName(string username)
        {
            _Username = username;
            if (CreateDataReader().HasRows && username == _Username)// TODO: checkUsername not the same
            {
                MessageBox.Show("Username already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
                return false;
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
            oleDbCommand.Parameters.AddWithValue("Username", _Username);
            oleDbCommand.CommandText = GetCommandText();
            return oleDbCommand;
        }

        private static void OpenConnection()
        {
            if (oleDbConnection.State == ConnectionState.Closed)
                oleDbConnection.Open();
        }

        private static string GetCommandText()
        {
            return "SELECT Username FROM WorkerSecurity WHERE Username=@Username";
        }
    }
}