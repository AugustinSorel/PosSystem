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
            if (CheckBoxChecked())
            {
                if (ChoiceIsYes())
                    ExecuteCommand(CreateCommand());
            }
            else
                ExecuteCommand(CreateCommand());
        }

        private bool ChoiceIsYes()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to give admin right to "+manageWorker.textBox1.Text, "Warning", MessageBoxButtons.YesNo);
            return dialogResult == DialogResult.Yes;
        }

        private bool CheckBoxChecked()
        {
            return manageWorker.checkBox1.Checked;
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = CreateCommandText();
            oleDbCommand.Parameters.AddWithValue("Password", manageWorker.textBox6.Text);
            oleDbCommand.Parameters.AddWithValue("Username", manageWorker.textBox5.Text);
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