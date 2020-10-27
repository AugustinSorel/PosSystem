namespace PosSystem
{
    internal class DisplayCategory
    {
        private readonly Category category;

        public DisplayCategory(Category category)
        {
            this.category = category;
            ShowSelectedData();
        }

        private void ShowSelectedData()
        {
            category.label5.Text = category.dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim();
            category.txtboxName.Text = category.dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
            category.TxtBoxDescription.Text = category.dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim();
        }
    }
}