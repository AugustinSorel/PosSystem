using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PosSystem
{
    class ShowUserDetails : SqlQueries
    {
        private string workerPhoto;
        private byte[] img;

        public ShowUserDetails(UserDetails userControl)
        {
            OpenConnectionString();
            OleDbCommand oleDbCommand = GetCommand();
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            while (oleDbDataReader.Read())
            {
                userControl.textBox1.Text = oleDbDataReader["WorkerName"].ToString();
                userControl.textBox2.Text = oleDbDataReader["WorkerSurname"].ToString();
                img = ((byte[])oleDbDataReader[5]); 
            }

            if (img == null)
            {
                userControl.pictureBox1.Image = null;
            }
            else
            {
                MemoryStream memoryStream = new MemoryStream(img);
                userControl.pictureBox1.Image = Image.FromStream(memoryStream);
            }

        }

        private static void OpenConnectionString()
        {
            if (oleDbConnection.State == ConnectionState.Closed)
                oleDbConnection.Open();
        }

        private OleDbCommand GetCommand()
        {
            OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = "select * from WorkerDetails where WorkerID = @WorkerID";
            oleDbCommand.Parameters.AddWithValue("FoodID", "1");
            return oleDbCommand;
        }
    }
}
