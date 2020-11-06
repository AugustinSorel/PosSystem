using System.Data;
using System.Data.OleDb;

namespace PosSystem
{
    internal class GetOrderID: SqlQueries
    {
        private static int HighestID = 0;
        private static int temp = 0;
        internal static int GetHigherOrder()
        {
            OleDbDataReader oleDbDataReader = GetCommand().ExecuteReader();
            while (oleDbDataReader.Read())
            {
                temp = int.Parse(oleDbDataReader["OrderID"].ToString());
                if (temp >= HighestID)
                    HighestID = temp;
            }
            HighestID++;
            return HighestID;
        }

        private static OleDbCommand GetCommand()
        {
            if (oleDbConnection.State == ConnectionState.Closed)
                oleDbConnection.Open();


            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            return oleDbCommand;
        }

        private static string GetCommandText()
        {
            return "select OrderID from OrderDetails";
        }
    }
}