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
                    userControl.TxtboxName.Text = oleDbDataReader["WorkerName"].ToString().Trim();
                    userControl.TxtboxSurname.Text = oleDbDataReader["WorkerSurname"].ToString().Trim();
                    userControl.TxtboxAge.Text = oleDbDataReader["Age"].ToString().Trim();
                    userControl.TxtboxGender.Text = oleDbDataReader["Gender"].ToString().Trim();
                    image = ((byte[])oleDbDataReader[5]);
                }
            }
            catch (System.Exception)
            {
            }

            if (image == null)
                userControl.UserPicture.Image = null;
            else
                userControl.UserPicture.Image = ConvertByteToImage(image); 
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
