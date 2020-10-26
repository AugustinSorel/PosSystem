using System.Data.OleDb;

namespace PosSystem
{
    class CreateCategoryTable : SqlQueries
    {
        public CreateCategoryTable()
        {
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommand();
            return oleDbCommand;
        }

        private string GetCommand()
        {
            return "CREATE TABLE Category("
                + "CategoryID AUTOINCREMENT,"
                + "CategoryName CHAR,"
                + "Description CHAR,"
                + "PRIMARY KEY(CategoryID)"
                + ")";
        }
    }
}
