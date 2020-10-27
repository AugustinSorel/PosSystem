using System.Windows.Forms;

namespace PosSystem
{
    internal class FilterDataGrid
    {
        private readonly DataGridView dataGridView;
        private readonly string textToKeep;

        public FilterDataGrid(DataGridView dataGridView, string textToKeep)
        {
            this.dataGridView = dataGridView;
            this.textToKeep = textToKeep;

            DeleteRow();
        }

        private void DeleteRow()
        {
            for (int i = dataGridView.RowCount - 1; i >= 0; i--)
                if (CheckifRowHasText(i))
                    dataGridView.Rows.Remove(dataGridView.Rows[i]);
        }

        private bool CheckifRowHasText(int i)
        {
            return dataGridView.Rows[i].Cells[1].Value.ToString().Trim() != textToKeep;
        }
    }
}