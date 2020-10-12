using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    class LoadDataGridView: SqlQueries
    {
        public LoadDataGridView(DataGridView dataGridView)
        {
            OleDbCommand oleDbCommand = CreateCommand();
            ExecuteCommand(oleDbCommand);
            dataGridView.DataSource = SetDataSource(oleDbCommand);
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = "SELECT * FROM WorkerDetails";
            return oleDbCommand;
        }
    }
}
