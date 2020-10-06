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
            oleDbCommand.Parameters.AddWithValue("WorkerName", manageWorker.txtBoxName.Text);
            oleDbCommand.Parameters.AddWithValue("WorkerSurname", manageWorker.txtBoxSurname.Text);
            oleDbCommand.Parameters.AddWithValue("Age", manageWorker.txtBoxAge.Text);
            oleDbCommand.Parameters.AddWithValue("Gender", manageWorker.txtBoxGender.Text);
            oleDbCommand.Parameters.AddWithValue("WorkerPhoto", ConvertImageToByte(manageWorker.WorkerPicture.Image));
            return oleDbCommand;
        }

        private string CreateCommandText()
        {
            return "INSERT INTO WorkerDetails(WorkerName, WorkerSurname, Age, Gender, WorkerPhoto) VALUES (?,?,?,?,?)";
        }
    }
}
