using System;
using System.Data.OleDb;

namespace PosSystem
{
    internal class AddToOrder: SqlQueries
    {
        public AddToOrder()
        {
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("WorkerID", UserDetailsVAR.Id);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "INSERT INTO Order (WorkerID) VALUES (?)";
        }
    }
}