using System.Data.OleDb;

namespace PosSystem
{
    class SaveUserDetails: SqlQueries
    {
        public SaveUserDetails(UserDetails userDetails)
        {
            ExecuteCommand(CreateCommand(userDetails));
        }

        private OleDbCommand CreateCommand(UserDetails userDetails)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("@WorkerName", userDetails.textBox1.Text);
            oleDbCommand.Parameters.AddWithValue("@WorkerSurname", userDetails.textBox2.Text);
            oleDbCommand.Parameters.AddWithValue("@Age", userDetails.textBox3.Text);
            oleDbCommand.Parameters.AddWithValue("@Gender", userDetails.textBox4.Text);
            oleDbCommand.Parameters.AddWithValue("@WorkerPhoto",ConvertImageToByte(userDetails.pictureBox1.Image));
            oleDbCommand.Parameters.AddWithValue("@WorkerID", UserDetailsVAR.Id);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "UPDATE WorkerDetails SET WorkerName=@WorkerName, WorkerSurname=@WorkerSurname, Age=@Age, Gender=@Gender, WorkerPhoto=@WorkerPhoto WHERE WorkerID = @WorkerID";
        }
    }
}
