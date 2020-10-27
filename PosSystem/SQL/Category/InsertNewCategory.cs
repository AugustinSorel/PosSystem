using System.Data.OleDb;

namespace PosSystem
{
    internal class InsertNewCategory: SqlQueries
    {
        private readonly Category category;

        public InsertNewCategory(Category category)
        {
            this.category = category;
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("CategoryName", category.textBoxInputName.Text);
            oleDbCommand.Parameters.AddWithValue("Description", category.textBoxInputDesc.Text);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "INSERT INTO Category (CategoryName, Description) VALUES (?,?)";
        }
    }
}