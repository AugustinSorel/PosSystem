using ADOX;
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
            CreateWrokerSecurityTable();
            CreateDefaultAdmin();
            CreateSaleTable();
            CreateItemsTable();
            CreateOrderTable();
            CreateOrderDetailsTable();
            CreateSupplierTable();
            CreateStockTable();
            CreateCustomer();
        }

        private void CreateCustomer()
        {
            new CreateCustomerTable();
        }

        private void CreateStockTable()
        {
            new CreateStockTable();
        }

        private void CreateOrderDetailsTable()
        {
            new CreateOrderDetailsTable();
        }

        private void CreateSupplierTable()
        {
            new CreateSupplierTable();
        }

        private void CreateOrderTable()
        {
            new CreateOrderTable();
        }

        private void CreateItemsTable()
        {
            new CreateItemsTable();
        }

        private void CreateSaleTable()
        {
            new CreateSaleTable();
        }

        private void CreateDefaultAdmin()
        {
            new CreateDefaultAdminDetails();
            new CreateAdminSecurity();
        }

        private void CreateWrokerSecurityTable()
        {
            new WorkerSecurityTable();
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
