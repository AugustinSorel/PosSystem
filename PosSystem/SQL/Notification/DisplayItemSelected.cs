using System.Data.OleDb;

namespace PosSystem
{
    internal class DisplayItemSelected: SqlQueries
    {
        private readonly HomePage homePage;

        public DisplayItemSelected(HomePage homePage)
        {
            this.homePage = homePage;
            OleDbDataReader oleDbDataReader = CreateCommand().ExecuteReader();

            if (oleDbDataReader.Read())
                homePage.pictureBoxItem.Image = ConvertByteToImage((byte[])oleDbDataReader["ProductPhoto"]);

            homePage.lblItemIDDisplay.Text = homePage.listView1.SelectedItems[0].SubItems[0].Text;
            homePage.label4.Text = homePage.listView1.SelectedItems[0].SubItems[1].Text;
            homePage.label6.Text = homePage.listView1.SelectedItems[0].SubItems[2].Text;
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("ItemID", homePage.listView1.SelectedItems[0].SubItems[0].Text);
            return oleDbCommand;
        }

        private string GetCommandText()
        {
            return "SELECT ProductPhoto FROM Items WHERE ItemID = @ItemID";
        }
    }
}