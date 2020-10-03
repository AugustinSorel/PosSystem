using System.Data.OleDb;

namespace PosSystem
{
    class UpdateWorkerDetails: SqlQueries
    {
        public UpdateWorkerDetails(SeeTeam seeTeam)
        {
            ExecuteCommand(CreateCommand(seeTeam));
        }

        private OleDbCommand CreateCommand(SeeTeam seeTeam)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("@WorkerName", seeTeam.textBox1.Text);
            oleDbCommand.Parameters.AddWithValue("@WorkerSurname", seeTeam.textBox2.Text);
            oleDbCommand.Parameters.AddWithValue("@Age", seeTeam.textBox3.Text);
            oleDbCommand.Parameters.AddWithValue("@Gender", seeTeam.textBox4.Text);
            oleDbCommand.Parameters.AddWithValue("@WorkerPhoto", ConvertImageToByte(seeTeam.pictureBox1.Image));
            oleDbCommand.Parameters.AddWithValue("@WorkerID", seeTeam.dataGridView1.SelectedRows[0].Cells[0].Value);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "UPDATE WorkerDetails SET WorkerName=@WorkerName, WorkerSurname=@WorkerSurname, Age=@Age, Gender=@Gender, WorkerPhoto=@WorkerPhoto WHERE WorkerID=@WorkerID";
        }
    }
}
