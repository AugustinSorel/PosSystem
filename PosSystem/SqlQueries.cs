﻿using System.Data;
using System.Data.OleDb;

namespace PosSystem
{
    class SqlQueries
    {
        protected const string DATABASE_NAME = "PosDatabase.mdb";
        protected const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + DATABASE_NAME + ";";
        protected static readonly OleDbConnection oleDbConnection = new OleDbConnection(CONNECTION_STRING);

        protected void CloseOleDbConnection()
        {
            if (oleDbConnection.State == ConnectionState.Open)
                oleDbConnection.Close();
        }

        protected void OpenOleDbConnection()
        {
            if (oleDbConnection.State == ConnectionState.Closed)
                oleDbConnection.Open();
        }

        protected void ExecuteCommand(OleDbCommand oleDbCommand)
        {
            try
            {
                OpenOleDbConnection();
                oleDbCommand.ExecuteNonQuery();
                CloseOleDbConnection();
            }
            catch (System.Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
    }
}
