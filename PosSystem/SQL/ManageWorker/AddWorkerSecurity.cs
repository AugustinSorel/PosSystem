using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    internal class AddWorkerSecurity: SqlQueries
    {
        private readonly ManageWorker manageWorker;

        public AddWorkerSecurity(ManageWorker manageWorker)
        {
            this.manageWorker = manageWorker;
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = CreateCommandText();
            oleDbCommand.Parameters.AddWithValue("Password", manageWorker.txtBoxPassword.Text);
            oleDbCommand.Parameters.AddWithValue("Username", manageWorker.txtBoxUsername.Text);
            oleDbCommand.Parameters.AddWithValue("Admin", manageWorker.checkBox1.Checked);
            MessageBox.Show("Worker saved successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return oleDbCommand;
        }

        private string CreateCommandText()
        {
            return "INSERT INTO WorkerSecurity ([Password], Username, Admin) VALUES (?,?,?)";
        }
    }
}