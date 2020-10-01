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
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommand();
            return oleDbCommand;
        }

        private string GetCommand()
        {
            return "CREATE TABLE WorkerDetails("
                + "WorkerID AUTOINCREMENT,"
                + "WorkerName CHAR(30),"
                + "WorkerSurname CHAR(30),"
                + "Age NUMERIC,"
                + "Gender CHAR(30),"
                + "WorkerPhoto OLEOBJECT,"
                + "PRIMARY KEY(WorkerID)"
                + ")";
        }
    }
}
