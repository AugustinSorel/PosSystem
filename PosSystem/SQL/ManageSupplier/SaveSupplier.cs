using System.Data.OleDb;

namespace PosSystem
{
    internal class SaveSupplier: SqlQueries
    {
        private readonly ManageSupplier manageSupplier;

        public SaveSupplier(ManageSupplier manageSupplier)
        {
            this.manageSupplier = manageSupplier;
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("SupplierName", manageSupplier.txtBoxName.Text);
            oleDbCommand.Parameters.AddWithValue("SupplierAddress", manageSupplier.txtBoxAddress.Text);
            oleDbCommand.Parameters.AddWithValue("PhoneNumber", manageSupplier.txtBoxPhone.Text);
            oleDbCommand.Parameters.AddWithValue("Mail", manageSupplier.txtBoxMail.Text);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "INSERT INTO Supplier (SupplierName, SupplierAddress, PhoneNumber, Mail) VALUES (?,?,?,?)";
        }
    }
}