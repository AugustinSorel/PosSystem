using System.Data.OleDb;

namespace PosSystem
{
    internal class SearchItemByCodeBar: SqlQueries
    {
        private Stock stock;

        public SearchItemByCodeBar(Stock stock)
        {
            this.stock = stock;
            OleDbCommand oleDbCommand = CreateCommand();
            ExecuteCommand(oleDbCommand);
            stock.dataGridView1.DataSource = SetDataSource(oleDbCommand);
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "SELECT * FROM Items WHERE [BarCode] like('" + stock.TxtBoxSearchName.Text + "%')";
        }
    }
}