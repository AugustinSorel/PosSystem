using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    class CheckIfItemBarCodeExists: SqlQueries
    {
        private static string BarCode;
        public static bool Check(string BarCode)
        {
            CheckIfItemBarCodeExists.BarCode = BarCode;
            if (CreateDataReader().HasRows)
                return true;
            else
            {
                MessageBox.Show("BarCode Doesnt exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            oleDbCommand.Parameters.AddWithValue("Barcode", BarCode);
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
            return "SELECT BarCode FROM Items WHERE BarCode=@Barcode";
        }
    }
}
