using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace PosSystem
{
    class CheckLoginDetails: SqlQueries
    {
        public static bool LoginDetailsIsCorrect(string username, string password)
        {
            string dummyun = username;
            string dummypw = password;
            if (oleDbConnection.State == ConnectionState.Closed)
                oleDbConnection.Open();

            using (OleDbCommand StrQuer = new OleDbCommand("SELECT * FROM WorkerSecurity WHERE Username=@userid AND Password=@password", oleDbConnection))
            {
                StrQuer.Parameters.AddWithValue("@userid", dummyun);
                StrQuer.Parameters.AddWithValue("@password", dummypw);
                OleDbDataReader dr = StrQuer.ExecuteReader();
                if(dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
