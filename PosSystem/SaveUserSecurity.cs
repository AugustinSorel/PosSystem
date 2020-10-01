using System.Data.OleDb;

namespace PosSystem
{
    class SaveUserSecurity: SqlQueries
    {
        public SaveUserSecurity(UserDetails userDetails)
        {
            ExecuteCommand(CreateCommand(userDetails));
            System.Windows.Forms.MessageBox.Show("Account Security saved successfully", "Message", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information); ;
        }

        private OleDbCommand CreateCommand(UserDetails userDetails)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("@Password", userDetails.textBox6.Text);
            oleDbCommand.Parameters.AddWithValue("@Username", userDetails.textBox5.Text);
            oleDbCommand.Parameters.AddWithValue("@WorkerID", UserDetailsVAR.Id);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "UPDATE WorkerSecurity SET [Password]=@Password, Username=@Username WHERE WorkerID = @WorkerID";
        }
    }
}