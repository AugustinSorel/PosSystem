using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    internal class UpdaateSupplier: SqlQueries
    {
        private readonly Supplier supplier;

        public UpdaateSupplier(Supplier supplier)
        {
            this.supplier = supplier;
            ExecuteCommand(CreateCommand());
            MessageBox.Show("The supplier has been successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("@SupplierName", supplier.TxtBoxName.Text);
            oleDbCommand.Parameters.AddWithValue("@SupplierAddress", supplier.TxtBoxAddress.Text);
            oleDbCommand.Parameters.AddWithValue("@PhoneNumber", supplier.textBoxPhone.Text);
            oleDbCommand.Parameters.AddWithValue("@Mail", supplier.textBoxMail.Text);
            oleDbCommand.Parameters.AddWithValue("@SupplierID", supplier.dataGridView1.SelectedRows[0].Cells[0].Value);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "UPDATE Supplier SET SupplierName=@SupplierName, SupplierAddress=@SupplierAddress, PhoneNumber=@PhoneNumber, Mail=@Mail WHERE SupplierID=@SupplierID";
        }
    }
}