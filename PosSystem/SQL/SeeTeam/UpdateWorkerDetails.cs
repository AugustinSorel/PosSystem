using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    class UpdateWorkerDetails: SqlQueries
    {
        public UpdateWorkerDetails(SeeTeam seeTeam)
        {
            ExecuteCommand(CreateCommand(seeTeam));
            MessageBox.Show("The worker has been successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private OleDbCommand CreateCommand(SeeTeam seeTeam)
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("@WorkerName", seeTeam.TxtBoxName.Text);
            oleDbCommand.Parameters.AddWithValue("@WorkerSurname", seeTeam.TxtBoxSurname.Text);
            oleDbCommand.Parameters.AddWithValue("@Age", seeTeam.TxtBoxAge.Text);
            oleDbCommand.Parameters.AddWithValue("@Gender", seeTeam.TxtBoxGender.Text);
            oleDbCommand.Parameters.AddWithValue("@WorkerPhoto", ConvertImageToByte(seeTeam.WorkerPicture.Image));
            oleDbCommand.Parameters.AddWithValue("@WorkerID", seeTeam.dataGridView1.SelectedRows[0].Cells[0].Value);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "UPDATE WorkerDetails SET WorkerName=@WorkerName, WorkerSurname=@WorkerSurname, Age=@Age, Gender=@Gender, WorkerPhoto=@WorkerPhoto WHERE WorkerID=@WorkerID";
        }
    }
}
