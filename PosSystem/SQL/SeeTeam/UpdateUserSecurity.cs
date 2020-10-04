using System.Data.OleDb;

namespace PosSystem
{
    internal class UpdateUserSecurity: SqlQueries
    {
        public UpdateUserSecurity(SeeTeam seeTeam)
        {
            ExecuteCommand(CreateCommand(seeTeam));
        }

        private OleDbCommand CreateCommand(SeeTeam seeTeam)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("@Username", seeTeam.textBox5.Text);
            oleDbCommand.Parameters.AddWithValue("@Password", seeTeam.textBox5.Text);
            oleDbCommand.Parameters.AddWithValue("@Admin", seeTeam.checkBox1.Checked);
            oleDbCommand.Parameters.AddWithValue("@WorkerID", seeTeam.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "UPDATE WorkerSecurity SET Username=@Username, [Password]=@Password, Admin=@Admin WHERE WorkerID=@WorkerID";
        }
    }
}