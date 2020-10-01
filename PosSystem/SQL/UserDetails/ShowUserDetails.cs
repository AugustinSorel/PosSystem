using System.Data.OleDb;

namespace PosSystem
{
    class ShowUserDetails : SqlQueries
    {
        private readonly byte[] image;

        public ShowUserDetails(UserDetails userControl)
        {
            OleDbDataReader oleDbDataReader = GetCommand().ExecuteReader();
            try
            {
                while (oleDbDataReader.Read())
                {
                    userControl.textBox1.Text = oleDbDataReader["WorkerName"].ToString();
                    userControl.textBox2.Text = oleDbDataReader["WorkerSurname"].ToString();
                    userControl.textBox3.Text = oleDbDataReader["Age"].ToString();
                    userControl.textBox4.Text = oleDbDataReader["Gender"].ToString();
                    image = ((byte[])oleDbDataReader[5]);
                }
            }
            catch (System.Exception)
            {
            }

            if (image == null)
                userControl.pictureBox1.Image = null;
            else
                userControl.pictureBox1.Image = ConvertByteToImage(image); 
        }

        private OleDbCommand GetCommand()
        {
            OpenOleDbConnection();
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = GetCommandText();
            oleDbCommand.Parameters.AddWithValue("WorkerID", UserDetailsVAR.Id);
            return oleDbCommand;
        }

        private static string GetCommandText()
        {
            return "select * from WorkerDetails where WorkerID = @WorkerID";
        }
    }
}
