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
            oleDbCommand.Parameters.AddWithValue("BarCode", ManageStock.TxtBoxBarCode.Text);
            oleDbCommand.Parameters.AddWithValue("UnitPrice", ManageStock.TxtBoxPrice.Text);
            oleDbCommand.Parameters.AddWithValue("ProductPhoto", ConvertImageToByte(ManageStock.pictureBoxItem.Image));
            oleDbCommand.Parameters.AddWithValue("StockMin", ManageStock.textBoxStockMin.Text);
            oleDbCommand.Parameters.AddWithValue("StockMax", ManageStock.textBoxStockMax.Text);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "INSERT INTO Items (Description, SupplierID, BarCode, UnitPrice, ProductPhoto, StockMin, StockMax) VALUES(?,?,?,?,?,?,?)";
        }
    }
}
