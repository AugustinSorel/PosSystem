using System.Data.OleDb;

namespace PosSystem
{
    internal class ShowUserSecurityFromDataGrid: SqlQueries
    {
        public ShowUserSecurityFromDataGrid(SeeTeam seeTeam)
        {
            OleDbDataReader oleDbDataReader = GetCommand(seeTeam).ExecuteReader();
            while (oleDbDataReader.Read())
            {
                seeTeam.TxtBoxUsername.Text = oleDbDataReader["UserName"].ToString().Trim();
                seeTeam.TxtBoxPassword.Text = oleDbDataReader["Password"].ToString().Trim();
                seeTeam.checkBox1.Checked = bool.Parse(oleDbDataReader["Admin"].ToString());
            }
        }

        private OleDbCommand GetCommand(SeeTeam seeTeam)
        {
            OpenOleDbConnection();
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("WorkerID", seeTeam.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            return oleDbCommand;
        }

        private static string GetCommandText()
        {
            return "select * from WorkerSecurity where WorkerID = @WorkerID";
        }
    }
}