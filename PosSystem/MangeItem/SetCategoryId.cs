using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    internal class SetCategoryId: SqlQueries
    {
        private readonly string CategoryID;

        public SetCategoryId(ComboBox comboBox2)
        {
            OleDbDataReader dr = GetCommand().ExecuteReader(CommandBehavior.SingleResult);
            while (dr.Read())
            {
                CategoryID = dr["CategoryID"].ToString().Trim();
                comboBox2.Items.Add(CategoryID);
            }

            if (comboBox2.Items.Count < 1)
            {
                comboBox2.Items.Add("NO CATEGORY");
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
            return "Select CategoryID from Category";
        }
    }
}