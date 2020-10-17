using System.Data.OleDb;

namespace PosSystem
{
    class AddProduct : SqlQueries
    {
        private readonly ManageItem ManageStock;

        public AddProduct(ManageItem manageStock)
        {
            ManageStock = manageStock;
            ExecuteCommand(CreateCommand());
            System.Windows.Forms.MessageBox.Show("Item Saved Succesfully", "Message", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("Description", ManageStock.TxtBoxDescrption.Text);
            oleDbCommand.Parameters.AddWithValue("SupplierID", ManageStock.TxtBoxSupplierID.Text);
            oleDbCommand.Parameters.AddWithValue("CategoryID", ManageStock.txtCategory.Text);
            oleDbCommand.Parameters.AddWithValue("PurchasePrice", ManageStock.TxtBoxPurchacePrice.Text);
            oleDbCommand.Parameters.AddWithValue("Coefficient", ManageStock.txtCoef.Text);
            oleDbCommand.Parameters.AddWithValue("SellingPrice", ManageStock.lblFinalPrice.Text);
            oleDbCommand.Parameters.AddWithValue("VatID", 1);
            oleDbCommand.Parameters.AddWithValue("BarCode", ManageStock.TxtBoxBarCode.Text);
            oleDbCommand.Parameters.AddWithValue("ProductPhoto", ConvertImageToByte(ManageStock.pictureBoxItem.Image));
            oleDbCommand.Parameters.AddWithValue("StockMin", ManageStock.textBoxStockMin.Text);
            oleDbCommand.Parameters.AddWithValue("StockMax", ManageStock.textBoxStockMax.Text);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "INSERT INTO Items (Description, SupplierID, CategoryID, PurchasePrice, Coefficient, SellingPrice, VatID, BarCode, ProductPhoto, StockMin, StockMax) VALUES(?,?,?,?,?,?,?,?,?,?,?)";
        }
    }
}
