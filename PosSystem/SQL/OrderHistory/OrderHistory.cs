using System.Data;
using System.Data.OleDb;

namespace PosSystem
{
    internal class OrderHistory: SqlQueries
    {
        private static string Day;
        private static float totalPrice;

        internal static float GetDay(string day)
        {
            Day = day;
            totalPrice = 0;
            OleDbDataReader dr = GetCommand().ExecuteReader(CommandBehavior.SingleResult);
            while (dr.Read())
                totalPrice += float.Parse(dr["Price"].ToString());

            return totalPrice;
        }

        private static OleDbCommand GetCommand()
        {
            OleDbCommand cmd = oleDbConnection.CreateCommand();
            cmd.CommandText = GetCommandText();
            cmd.Parameters.AddWithValue("@OrderDate", Day);

            if (oleDbConnection.State == ConnectionState.Closed)
                oleDbConnection.Open();

            return cmd;
        }

        private static string GetCommandText()
        {
            return "Select Price from OrderDetails WHERE OrderDate=@OrderDate";
        }
    }
}
