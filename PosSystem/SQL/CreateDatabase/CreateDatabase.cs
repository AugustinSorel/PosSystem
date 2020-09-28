using ADOX;
using System.Data.OleDb;
using System.IO;

namespace PosSystem
{
    class CreateDatabase: SqlQueries
    {
        public CreateDatabase()
        {
            CreateDB();
        }

        private void CreateDB()
        {
            CreateCatalogue();
            CreateWorkerDetailsTable();
        }

        private void CreateWorkerDetailsTable()
        {
            new CreateWorkerDetailsTable();
        }

        private void CreateCatalogue()
        {
            CatalogClass catalogClass = new CatalogClass();
            catalogClass.Create(CONNECTION_STRING);
        }

        public static bool CheckifDatabaseExists()
        {
            return !File.Exists(DATABASE_NAME);
        }
    }
}
