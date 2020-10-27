using System.Data;
using System.Data.OleDb;

namespace PosSystem
{
    internal class SetSupplierId: SqlQueries
    {
        private readonly string supplierID;

        public SetSupplierId(System.Windows.Forms.ComboBox comboBox1)
        {
            OleDbDataReader dr = GetCommand().ExecuteReader(CommandBehavior.SingleResult);
            while (dr.Read())
            {
                supplierID = dr["SupplierID"].ToString().Trim();
                comboBox1.Items.Add(supplierID);
            }

            if (comboBox1.Items.Count < 1)
            {
                comboBox1.Items.Add("NO SUPPLIER");
            }
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
            return "Select SupplierID from Supplier";
        }
    }
}