using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    internal class LoadDataGridViewStock: SqlQueries
    {
        public LoadDataGridViewStock(DataGridView dataGridView)
        {
            OleDbCommand oleDbCommand = CreateCommand();
            ExecuteCommand(oleDbCommand);
            dataGridView.DataSource = SetDataSource(oleDbCommand);
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = "SELECT * FROM items";
            return oleDbCommand;
        }

    }
}