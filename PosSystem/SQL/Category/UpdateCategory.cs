using System.Data.OleDb;

namespace PosSystem
{
    internal class UpdateCategory: SqlQueries
    {
        private readonly Category category;

        public UpdateCategory(Category category)
        {
            this.category = category;
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("@CategoryName", category.txtboxName.Text);
            oleDbCommand.Parameters.AddWithValue("@Description", category.TxtBoxDescription.Text);
            oleDbCommand.Parameters.AddWithValue("@CategoryID", category.label5.Text);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "UPDATE Category SET CategoryName=@CategoryName, Description=@Description WHERE CategoryID=@CategoryID";
        }
    }
}