using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    class SeeTeamCheckIfUserNameIsTaken: SqlQueries
    {
        private static string _Username;
        private static string _ID;

        public static bool CheckUserName(SeeTeam seeTeam)
        {
            _Username = seeTeam.TxtBoxUsername.Text;
            if (CreateDataReader().HasRows && seeTeam.dataGridView1.SelectedRows[0].Cells[0].Value.ToString() != _ID)
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
            
            
            while (dataReader.Read())
                _ID = dataReader["WorkerID"].ToString().Trim();
            
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
            return "SELECT WorkerID FROM WorkerSecurity WHERE Username=@Username";
        }
    }
}