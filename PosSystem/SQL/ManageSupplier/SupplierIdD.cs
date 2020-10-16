using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    internal class SupplierIdD: SqlQueries
    {
        private static string SupplierID;
        internal static bool Exists(string text)
        {
            SupplierID = text;
            if (CreateDataReader().HasRows)
                return true;
            else
            {
                MessageBox.Show("SupplierID Doesnt exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private static OleDbDataReader CreateDataReader()
        {
            OleDbDataReader dataReader = CreateCommand().ExecuteReader();
            return dataReader;
        }

        private static OleDbCommand CreateCommand()
        {
            OpenConnection();
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.Parameters.AddWithValue("SupplierID", SupplierID);
            oleDbCommand.CommandText = GetCommandText();
            return oleDbCommand;
        }

        private static void OpenConnection()
        {
            if (oleDbConnection.State == ConnectionState.Closed)
                oleDbConnection.Open();
        }

        private static string GetCommandText()
        {
            return "SELECT SupplierID FROM Supplier WHERE SupplierID=@SupplierID";
        }
    }
}