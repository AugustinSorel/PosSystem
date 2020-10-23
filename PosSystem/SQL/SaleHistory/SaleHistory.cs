using System;
using System.Data;
using System.Data.OleDb;

namespace PosSystem
{
    internal class SaleHistory: SqlQueries
    {
        private static string day1 = DateTime.Now.AddDays(-7).ToString("dd-MM-yyyy");
        private static float totalPrice = 0;

        internal static float GetDay1()
        {
            OleDbDataReader dr = GetCommand().ExecuteReader(CommandBehavior.SingleResult);
            while (dr.Read())
                totalPrice += float.Parse(dr["TotalPrice"].ToString());

            return totalPrice;
        }

        private static OleDbCommand GetCommand()
        {
            OleDbCommand cmd = oleDbConnection.CreateCommand();
            cmd.CommandText = GetCommandText();
            cmd.Parameters.AddWithValue("@ReceiptDate", day1);

            if (oleDbConnection.State == ConnectionState.Closed)
                oleDbConnection.Open();

            return cmd;
        }

        private static string GetCommandText()
        {
            return "Select TotalPrice from Sale WHERE ReceiptDate=@ReceiptDate";
        }
    }
}