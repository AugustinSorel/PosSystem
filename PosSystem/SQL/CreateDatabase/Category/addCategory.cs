using System.Collections.Generic;
using System.Data.OleDb;

namespace PosSystem
{
    internal class AddCategory: SqlQueries
    {
        private readonly string CategoryName;
        private readonly string Desciption;

        public AddCategory()
        {
            foreach (KeyValuePair<string, string> category in CategoryDictionary.category)
            {
                CategoryName = category.Key.ToString();
                Desciption = category.Value.ToString();
                ExecuteCommand(CreateCommand());
            }
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("CategoryName", CategoryName);
            oleDbCommand.Parameters.AddWithValue("Description", Desciption);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "INSERT INTO Category (CategoryName, Description) Values (?,?)";
        }
    }
}