using ADOX;
using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace PosSystem
{
    class CreateDatabase: SqlQueries
    {
        public CreateDatabase()
        {
            if (!File.Exists(DATABASE_NAME))
                CreateDB();
        }

        private void CreateDB()
        {
            CreateCatalogue();
            ExecuteCommand(CreateCommand());
        }

        private OleDbCommand CreateCommand()
        {
            OleDbCommand oleDbCommand = new OleDbCommand
            {
                Connection = oleDbConnection,
                CommandText = GetCommand()
            };
            return oleDbCommand;
        }

        private string GetCommand()
        {
            return "CREATE TABLE BOOK("
                + "BookID SHORT NOT NULL,"
                + "Title CHAR(30),"
                + "PRIMARY KEY(BookID)"
                + ")";
        }

        private CatalogClass CreateCatalogue()
        {
            try
            {
                CatalogClass catalogClass = new CatalogClass();
                catalogClass.Create(CONNECTION_STRING);
                return catalogClass;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR in CreateDatabase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
