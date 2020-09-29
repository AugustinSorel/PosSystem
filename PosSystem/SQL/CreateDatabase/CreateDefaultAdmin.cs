using System.Data.OleDb;

namespace PosSystem
{
    class CreateDefaultAdmin: SqlQueries
    {
        private const string ADMIN = "Admin";

        public CreateDefaultAdmin()
        {
            ExecuteCommand(GetCommand());
        }

        private OleDbCommand GetCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("WorkerName", ADMIN);
            oleDbCommand.Parameters.AddWithValue("WorkerSurname", ADMIN);
            oleDbCommand.Parameters.AddWithValue("Age", 0);
            oleDbCommand.Parameters.AddWithValue("Gender", "Unknown");
            oleDbCommand.Parameters.AddWithValue("WorkerPhoto", ConvertImageToByte(Properties.Resources.DefaultAvatar));
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "INSERT INTO WorkerDetails (WorkerName, WorkerSurname, Age, Gender, WorkerPhoto) VALUES (?, ?, ?, ?, ?)";
        }
    }
}
