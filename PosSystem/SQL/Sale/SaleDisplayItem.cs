using System.Data.OleDb;

namespace PosSystem
{
    internal class SaleDisplayItem: SqlQueries
    {
        private readonly Sale sale;
        private readonly byte[] image;

        public SaleDisplayItem(Sale sale)
        {
            this.sale = sale;
            OleDbDataReader oleDbDataReader = GetCommand().ExecuteReader();
            while (oleDbDataReader.Read())
            {
                sale.TxtBoxDescrption.Text = oleDbDataReader["Description"].ToString().Trim();
                sale.lblFinalPrice.Text = oleDbDataReader["SellingPrice"].ToString().Trim();
                sale.lblItemIDDisplay.Text = oleDbDataReader["ItemID"].ToString().Trim();
                image = ((byte[])oleDbDataReader[9]);
            }
            sale.pictureBoxItem.Image = ConvertByteToImage(image);
        }

        private OleDbCommand GetCommand()
        {
            OpenOleDbConnection();
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("Barcode", sale.textBox1.Text);
            return oleDbCommand;
        }

        private static string GetCommandText()
        {
            return "select * from Items where BarCode = @Barcode";
        }
    }
}