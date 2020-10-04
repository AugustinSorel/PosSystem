using System.Data.OleDb;

namespace PosSystem
{
    class AddWorkerDetails : SqlQueries
    {
        private readonly ManageWorker manageWorker;

        public AddWorkerDetails(ManageWorker manageWorker)
        {
            this.manageWorker = manageWorker;
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = CreateCommandText();
            oleDbCommand.Parameters.AddWithValue("WorkerName", manageWorker.textBox1.Text);
            oleDbCommand.Parameters.AddWithValue("WorkerSurname", manageWorker.textBox2.Text);
            oleDbCommand.Parameters.AddWithValue("Age", manageWorker.textBox3.Text);
            oleDbCommand.Parameters.AddWithValue("Gender", manageWorker.textBox4.Text);
            oleDbCommand.Parameters.AddWithValue("WorkerPhoto", ConvertImageToByte(manageWorker.pictureBox1.Image));
            return oleDbCommand;
        }

        private string CreateCommandText()
        {
            return "INSERT INTO WorkerDetails(WorkerName, WorkerSurname, Age, Gender, WorkerPhoto) VALUES (?,?,?,?,?)";
        }
    }
}
