using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    internal class DeleteWorkerSecurity: SqlQueries
    {
        private readonly ManageWorker manageWorker;

        public DeleteWorkerSecurity(ManageWorker manageWorker)
        {
            this.manageWorker = manageWorker;
            ExecuteCommand(CreateCommand());
            MessageBox.Show("This worker has been successfully deleted from the databse", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("WorkerID", manageWorker.txtDelete.Text);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "DELETE FROM WorkerSecurity WHERE WorkerID=@WorkerID";
        }
    }
}