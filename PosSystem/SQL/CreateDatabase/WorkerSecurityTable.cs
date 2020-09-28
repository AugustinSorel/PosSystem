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
            OleDbCommand oleDbCommand = new OleDbCommand
            {
                Connection = oleDbConnection,
                CommandText = GetCommand()
            };
            return oleDbCommand;
        }

        private string GetCommand()
        {
            return "CREATE TABLE WorkerSecurity("
                + "WorkerID NUMERIC,"
                + "Username CHAR(30),"
                + "[Password] CHAR(30),"
                + "Admin BIT NOT NULL DEFAULT 0"//?
                + ")";
        }
    }
}
