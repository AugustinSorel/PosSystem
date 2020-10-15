using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    internal class OrderByItemPrice: SqlQueries
    {
        public OrderByItemPrice(DataGridView dataGridView1)
        {
            OleDbCommand oleDbCommand = CreateCommand();
            ExecuteCommand(oleDbCommand);
            dataGridView1.DataSource = SetDataSource(oleDbCommand);
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "SELECT UnitPrice, BarCode From Items ORDER BY UnitPrice";
        }
    }
}