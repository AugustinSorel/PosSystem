using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    class OrderByWorkerAdmin: SqlQueries
    {
        public OrderByWorkerAdmin(DataGridView dataGridView)
        {
            OleDbCommand oleDbCommand = CreateCommand();
            ExecuteCommand(oleDbCommand);
            dataGridView.DataSource = SetDataSource(oleDbCommand);
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "SELECT WorkerName, Admin From WorkerSecurity INNER JOIN WorkerDetails ON WorkerSecurity.WorkerID = WorkerDetails.WorkerID ORDER BY Admin";
        }
    }
}