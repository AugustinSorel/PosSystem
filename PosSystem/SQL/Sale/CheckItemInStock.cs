using System;
using System.Data;
using System.Data.OleDb;

namespace PosSystem
{
    internal class CheckItemInStock: SqlQueries
    {
        private static int Quantity;
        private static string Barcode;

        public static bool CheckIfEnoughStock(string barcode)
        {
            Barcode = barcode;
            OleDbDataReader dr = GetCommand().ExecuteReader(CommandBehavior.SingleResult);
            if (dr.Read())
                Quantity = int.Parse(dr["stockquantity"].ToString());

            if (Quantity > 0)
                return true;
            else
            {
                System.Windows.Forms.MessageBox.Show("The product " + barcode + " is out of stock");
                return false;
            }
        }

        private static OleDbCommand GetCommand()
        {
            OleDbCommand cmd = oleDbConnection.CreateCommand();
            cmd.CommandText = GetCommandText();
            cmd.Parameters.AddWithValue("@Barcode", Barcode);

            if (oleDbConnection.State == ConnectionState.Closed)
                oleDbConnection.Open();

            return cmd;
        }

        private static string GetCommandText()
        {
            return "Select [StockQuantity] from Stock WHERE ItemID=@ItemID";
        }
    }
}