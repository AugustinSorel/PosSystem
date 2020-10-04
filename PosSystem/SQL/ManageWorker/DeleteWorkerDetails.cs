using System.Data.OleDb;

namespace PosSystem
{
    class DeleteWorkerDetails: SqlQueries
    {
        private readonly ManageWorker manageWorker;

        public DeleteWorkerDetails(ManageWorker manageWorker)
        {
            this.manageWorker = manageWorker;
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("WorkerID", manageWorker.textBox7.Text);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "DELETE FROM WorkerDetails WHERE WorkerID=@WorkerID";
        }
    }
}