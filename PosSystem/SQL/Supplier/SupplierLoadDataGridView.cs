using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    internal class SupplierLoadDataGridView: SqlQueries
    {
        public SupplierLoadDataGridView(DataGridView dataGridView1)
        {
            OleDbCommand oleDbCommand = CreateCommand();
            ExecuteCommand(oleDbCommand);
            dataGridView1.DataSource = SetDataSource(oleDbCommand);
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = "SELECT * FROM Supplier";
            return oleDbCommand;
        }
    }
}