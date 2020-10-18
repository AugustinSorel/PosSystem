using System.Data.OleDb;

namespace PosSystem
{
    internal class SupplierSearch: SqlQueries
    {
        private Supplier supplier;

        public SupplierSearch(Supplier supplier)
        {
            this.supplier = supplier;
            OleDbCommand oleDbCommand = CreateCommand();
            ExecuteCommand(oleDbCommand);
            supplier.dataGridView1.DataSource = SetDataSource(oleDbCommand);
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "SELECT * FROM Supplier WHERE [SupplierName] like('" + supplier.TxtBoxSearchName.Text + "%')";
        }
    }
}