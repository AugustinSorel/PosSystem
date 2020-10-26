using System.Data.OleDb;

namespace PosSystem
{
    internal class AddVat: SqlQueries
    {
        public AddVat()
        {
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = CreateCommandText();
            oleDbCommand.Parameters.AddWithValue("VatRate", 0.2);
            return oleDbCommand;
        }

        private string CreateCommandText()
        {
            return "INSERT INTO VAT (VatRate) VALUES (?)";
        }
    }
}