using System.Data.OleDb;

namespace PosSystem
{
    class WorkerSecurityTable: SqlQueries
    {
        public WorkerSecurityTable()
        {
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommand();
            return oleDbCommand;
        }

        private string GetCommand()
        {
            return "CREATE TABLE WorkerSecurity("
                + "WorkerID AUTOINCREMENT,"
                + "Username CHAR(30),"
                + "[Password] CHAR(30),"
                + "Admin BIT NOT NULL DEFAULT 0"//?
                + ")";
        }
    }
}
