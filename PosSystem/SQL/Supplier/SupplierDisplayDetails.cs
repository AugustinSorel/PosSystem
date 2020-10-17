namespace PosSystem
{
    internal class SupplierDisplayDetails
    {
        private Supplier supplier;

        public SupplierDisplayDetails(Supplier supplier)
        {
            this.supplier = supplier;
            ShowSelectedData();
        }

        private void ShowSelectedData()
        {
            supplier.TxtBoxName.Text = supplier.dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
            supplier.TxtBoxAddress.Text = supplier.dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim();
            supplier.textBoxPhone.Text = supplier.dataGridView1.SelectedRows[0].Cells[3].Value.ToString().Trim();
            supplier.textBoxMail.Text = supplier.dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim();
        }
    }
}