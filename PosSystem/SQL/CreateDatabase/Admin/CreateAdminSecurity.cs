using System.Data.OleDb;

namespace PosSystem
{
    class CreateAdminSecurity: SqlQueries
    {
        private const string ADMIN = "Admin";

        public CreateAdminSecurity()
        {
            ExecuteCommand(GetCommand());
        }

        private OleDbCommand GetCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("Username", ADMIN);
            oleDbCommand.Parameters.AddWithValue("[Password]", PasswordSecurity.EncryptMD5(ADMIN));
            oleDbCommand.Parameters.AddWithValue("Admin", "-1");
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "INSERT INTO WorkerSecurity (Username, [Password], Admin) VALUES (?, ?, ?)";
        }
    }
}
