using System.Data.OleDb;

namespace PosSystem
{
    internal class UpdateStockQuantity: SqlQueries
    {
        private readonly Stock stock;

        public UpdateStockQuantity(Stock stock)
        {
            this.stock = stock;
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("StockQuantity", stock.txtboxQuantity.Text);
            oleDbCommand.Parameters.AddWithValue("ItemID", stock.dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "UPDATE Stock SET StockQuantity=@StockQuantity WHERE ItemID=@ItemID";
        }
    }
}