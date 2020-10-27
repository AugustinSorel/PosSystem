using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    internal class CategoryLoadData: SqlQueries
    {
        public CategoryLoadData(DataGridView dataGridView1)
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

        private static string GetCommandText()
        {
            return "SELECT * FROM Category";
        }
    }
}