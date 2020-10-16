using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    internal class DeleteItem: SqlQueries
    {
        private string CodeBar;

        public DeleteItem(string text)
        {
            CodeBar = text;
            ExecuteCommand(CreateCommand());
            MessageBox.Show("This Item has been successfully deleted from the databse", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("CodeBar", CodeBar);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "DELETE FROM items WHERE BarCode=@CodeBar";
        }
    }
}