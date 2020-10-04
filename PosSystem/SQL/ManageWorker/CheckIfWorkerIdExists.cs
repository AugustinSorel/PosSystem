using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    class CheckIfWorkerIdExists: SqlQueries
    {
        private static string ID;
        public static bool IdExists(string id)
        {
            ID = id;
            if (CreateDataReader().HasRows)
                return true;
            else
            {
                MessageBox.Show("ID Doesnt exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
            oleDbCommand.Parameters.AddWithValue("WorkerID", ID);
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
            return "SELECT WorkerID FROM WorkerSecurity WHERE WorkerID=@WorkerID";
        }
    }
}
