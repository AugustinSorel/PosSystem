using System.Data;
using System.Data.OleDb;

namespace PosSystem
{
    class SearchWorkerByName: SqlQueries
    {
        private readonly SeeTeam seeTeam;

        public SearchWorkerByName(SeeTeam seeTeam)
        {
            this.seeTeam = seeTeam;
            OleDbCommand oleDbCommand = CreateCommand();
            ExecuteCommand(oleDbCommand);
            seeTeam.dataGridView1.DataSource = SetDataSource(oleDbCommand);
        }

        protected object SetDataSource(OleDbCommand oleDbCommand)
        {
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);

            return dataTable;
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "SELECT * FROM WorkerDetails WHERE [WorkerName] like('" + seeTeam.TxtBoxSearchName.Text + "%')";
        }
    }
}