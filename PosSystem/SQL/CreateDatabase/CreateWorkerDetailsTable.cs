using System.Data.OleDb;

namespace PosSystem
{
    class CreateWorkerDetailsTable : SqlQueries
    {
        public CreateWorkerDetailsTable()
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
            return "CREATE TABLE WorkerDetails("
                + "WorkerID SHORT NOT NULL,"
                + "WorkerName CHAR(30),"
                + "WorkerSurname CHAR(30),"
                + "Age NUMERIC,"
                + "Gender CHAR(30),"
                + "PRIMARY KEY(WorkerID)"
                + ")";
        }
    }
}
