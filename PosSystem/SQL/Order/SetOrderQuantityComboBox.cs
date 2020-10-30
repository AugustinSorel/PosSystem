using System.Data;
using System.Data.OleDb;

namespace PosSystem
{
    internal class SetOrderQuantityComboBox: SqlQueries
    {
        private readonly string supplierID;

        public SetOrderQuantityComboBox(System.Windows.Forms.ComboBox comboBox1)
        {
            OleDbDataReader dr = GetCommand().ExecuteReader(CommandBehavior.SingleResult);
            while (dr.Read())
            {
                supplierID = dr["ItemID"].ToString().Trim();
                comboBox1.Items.Add(supplierID);
            }

            if (comboBox1.Items.Count < 1)
                comboBox1.Items.Add("NO ITEM");
        }

        private OleDbCommand GetCommand()
        {
            OleDbCommand cmd = oleDbConnection.CreateCommand();
            cmd.CommandText = GetCommandText();

            if (oleDbConnection.State == ConnectionState.Closed)
                oleDbConnection.Open();

            return cmd;
        }

        private string GetCommandText()
        {
            return "Select ItemID from Items";
        }
    }
}