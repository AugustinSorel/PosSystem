using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    class ManageItemBarCode: SqlQueries
    {
        private static ManageItem _manageItem;

        internal static bool CheckIfBarCodeIsUnique(ManageItem manageItem) 
        {
            _manageItem = manageItem;
            if (CreateDataReader().HasRows)
            {
                MessageBox.Show("BarCode is already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
                return false;
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
            oleDbCommand.Parameters.AddWithValue("BarCode", _manageItem.TxtBoxBarCode.Text);
            return oleDbCommand;
        }

        private static void OpenConnection()
        {
            if (oleDbConnection.State == ConnectionState.Closed)
                oleDbConnection.Open();
        }

        private static string GetCommandText()
        {
            return "SELECT BarCode FROM Items WHERE BarCode=@BarCode";
        }
    }
}
