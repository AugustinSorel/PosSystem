using System.Data.OleDb;

namespace PosSystem
{
    internal class OrderDisplayItem: SqlQueries
    {
        private readonly Order order;
        private readonly byte[] image;

        public OrderDisplayItem(Order order)
        {
            this.order = order;
            OleDbDataReader oleDbDataReader = GetCommand().ExecuteReader();
            while (oleDbDataReader.Read())
            {
                order.lblDescriptionDisplay.Text = oleDbDataReader["Description"].ToString().Trim();
                order.lblFinalPrice.Text = oleDbDataReader["SellingPrice"].ToString().Trim();
                order.lblItemIDDisplay.Text = oleDbDataReader["BarCode"].ToString().Trim();
                image = ((byte[])oleDbDataReader[9]);
            }
            order.pictureBoxItem.Image = ConvertByteToImage(image);
        }

        private OleDbCommand GetCommand()
        {
            OpenOleDbConnection();
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("ItemID", order.comboBox1.SelectedItem.ToString());
            return oleDbCommand;
        }

        private static string GetCommandText()
        {
            return "select * from Items where BarCode = @BarCode";
        }
    }
}