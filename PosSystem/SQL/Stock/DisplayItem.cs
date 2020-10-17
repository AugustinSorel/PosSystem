using System.Data.OleDb;

namespace PosSystem
{
    internal class DisplayItem: SqlQueries
    {
        private Stock stock;

        public DisplayItem(Stock stock)
        {
            this.stock = stock;
            OleDbDataReader oleDbDataReader = GetCommand().ExecuteReader();

            while (oleDbDataReader.Read())
                stock.txtboxQuantity.Text = oleDbDataReader["StockQuantity"].ToString().Trim();
        }

        private OleDbCommand GetCommand()
        {
            OpenOleDbConnection();
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("ItemID", stock.dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
            return oleDbCommand;
        }

        private static string GetCommandText()
        {
            return "select StockQuantity from Stock where ItemID = @ItemID";
        }
    }
}