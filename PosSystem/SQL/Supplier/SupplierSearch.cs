using System.Collections;

namespace PosSystem
{
    internal class SupplierSearch : SqlQueries
    {
        private readonly Supplier supplier;
        private readonly Hashtable my_hashtable = new Hashtable();

        public SupplierSearch(Supplier supplier)
        {
            this.supplier = supplier;
            PopulateHashTable();

            if (TextFound())
                DisplaySupplier();
            else
                System.Windows.Forms.MessageBox.Show("Supplier not found", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        private void DisplaySupplier()
        {
            for (int i = supplier.dataGridView1.RowCount - 1; i >= 0; i--)
            {
                System.Windows.Forms.DataGridViewRow row = supplier.dataGridView1.Rows[i];
                if (RowNameIsNotTextSearch(i))
                    supplier.dataGridView1.Rows.Remove(row);
            }
        }

        private bool RowNameIsNotTextSearch(int i)
        {
            return supplier.dataGridView1.Rows[i].Cells[1].Value.ToString().Trim() != supplier.TxtBoxSearchName.Text;
        }

        private void PopulateHashTable()
        {
            for (int i = 0; i < supplier.dataGridView1.Rows.Count; i++)
                my_hashtable.Add(i, supplier.dataGridView1.Rows[i].Cells[1].Value.ToString().Trim());
        }

        private bool TextFound()
        {
            return my_hashtable.ContainsValue(supplier.TxtBoxSearchName.Text);
        }
    }
}