using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    internal class ManageItemSupplier: SqlQueries
    {
        private static string SupplierID;

        internal static bool CheckIfSupplierIDIsUnique(string supplierID)
        {
            SupplierID = supplierID;
            if (CreateDataReader().HasRows)
                return true;
            else
            {
                MessageBox.Show("SupplierID Does not Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("SupplierID", SupplierID);
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