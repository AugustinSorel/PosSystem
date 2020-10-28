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
            oleDbCommand.Parameters.AddWithValue("SupplierID", stock.comboBox1.SelectedItem.ToString());

            oleDbCommand.Parameters.AddWithValue("CategoryID", stock.comboBox2.SelectedItem.ToString());
            oleDbCommand.Parameters.AddWithValue("PurchasePrice", stock.TxtBoxPurchacePrice.Text);
            oleDbCommand.Parameters.AddWithValue("Coefficient", stock.txtCoef.Text);
            oleDbCommand.Parameters.AddWithValue("SellingPrice", stock.lblFinalPrice.Text);

            oleDbCommand.Parameters.AddWithValue("ProductPhoto", ConvertImageToByte(stock.pictureBoxItem.Image));
            oleDbCommand.Parameters.AddWithValue("StockMin", stock.textBoxStockMin.Text);
            oleDbCommand.Parameters.AddWithValue("StockMax", stock.textBoxStockMax.Text);
            oleDbCommand.Parameters.AddWithValue("ItemID", stock.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "UPDATE Items SET Description=@Descritpion, SupplierID=@SupplierID, CategoryID=@CategoryID, PurchasePrice=@PurchasePrice, Coefficient=@Coefficient, SellingPrice=@SellingPrice, ProductPhoto=@ProductPhoto, StockMin=@StockMin, StockMax=@StockMax WHERE ItemID=@ItemID";
        }
    }
}