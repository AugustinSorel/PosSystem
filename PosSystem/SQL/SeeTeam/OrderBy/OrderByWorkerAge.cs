using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    class OrderByWorkerAge: SqlQueries
    {
        public OrderByWorkerAge(DataGridView dataGridView)
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
            return "SELECT WorkerName, Age From WorkerDetails ORDER BY Age";
        }
    }
}