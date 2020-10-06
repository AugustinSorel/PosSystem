using System.Data.OleDb;

namespace PosSystem
{
    class ShowUserSecurity: SqlQueries
    {
        public ShowUserSecurity(UserDetails userControl)
        {
            OleDbDataReader oleDbDataReader = GetCommand().ExecuteReader();
            while (oleDbDataReader.Read())
            {
                userControl.TxtboxUsername.Text = oleDbDataReader["UserName"].ToString().Trim();
                userControl.TxtboxPassword.Text = oleDbDataReader["Password"].ToString().Trim();
                userControl.checkBox1.Checked = bool.Parse(oleDbDataReader["Admin"].ToString());
            }

            if (! userControl.checkBox1.Checked)
            {
                userControl.checkBox1.Visible = false;
                userControl.label6.Visible = false;
            }
        }

        private OleDbCommand GetCommand()
        {
            OpenOleDbConnection();
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
