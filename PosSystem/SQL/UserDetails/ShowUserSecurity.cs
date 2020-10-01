using System.Data.OleDb;

namespace PosSystem
{
    class ShowUserSecurity: SqlQueries
    {
        public ShowUserSecurity(UserDetails userControl)
        {
            OpenOleDbConnection();
            OleDbDataReader oleDbDataReader = GetCommand().ExecuteReader();
            while (oleDbDataReader.Read())
            {
                userControl.textBox5.Text = oleDbDataReader["UserName"].ToString();
                userControl.textBox6.Text = oleDbDataReader["Password"].ToString();
            }
        }

        private OleDbCommand GetCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("WorkerID", UserDetailsVAR.Id);
            return oleDbCommand;
        }

        private static string GetCommandText()
        {
            return "select * from WorkerSecurity where WorkerID = @WorkerID";
        }
    }
}
