using System;
using System.Data.OleDb;

namespace PosSystem
{
    class SaveUserSecurity: SqlQueries
    {
        public SaveUserSecurity(UserDetails userDetails)
        {
            ExecuteCommand(CreateCommand(userDetails));
        }

        private OleDbCommand CreateCommand(UserDetails userDetails)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("@Password", userDetails.textBox6.Text);
            oleDbCommand.Parameters.AddWithValue("@Username", userDetails.textBox5.Text);
            oleDbCommand.Parameters.AddWithValue("@Admin", userDetails.checkBox1.Checked);
            oleDbCommand.Parameters.AddWithValue("@WorkerID", UserDetailsVAR.Id);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "UPDATE WorkerSecurity SET [Password]=@Password, Username=@Username, Admin=@Admin WHERE WorkerID = @WorkerID";
        }
    }
}