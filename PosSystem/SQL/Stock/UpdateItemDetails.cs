using System.Data.OleDb;

namespace PosSystem
{
    internal class UpdateItemDetails: SqlQueries
    {
        private readonly Stock stock;

        public UpdateItemDetails(Stock stock)
        {
            this.stock = stock;
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("Descritpion", stock.TxtBoxDescrption.Text);
            oleDbCommand.Parameters.AddWithValue("SupplierID", stock.TxtBoxSupplierID.Text);
            oleDbCommand.Parameters.AddWithValue("UnitPrice", stock.TxtBoxPrice.Text);
            oleDbCommand.Parameters.AddWithValue("ProductPhoto", ConvertImageToByte(stock.pictureBoxItem.Image));
            oleDbCommand.Parameters.AddWithValue("StockMin", stock.textBoxStockMin.Text);
            oleDbCommand.Parameters.AddWithValue("StockMax", stock.textBoxStockMax.Text);
            oleDbCommand.Parameters.AddWithValue("ItemID", stock.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "UPDATE Items SET Description=@Descritpion, SupplierID=@SupplierID, UnitPrice=@UnitPrice, ProductPhoto=@ProductPhoto, StockMin=@StockMin, StockMax=@StockMax WHERE ItemID=@ItemID";
        }
    }
}