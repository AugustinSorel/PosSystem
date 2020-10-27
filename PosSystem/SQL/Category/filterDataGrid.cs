using System.Windows.Forms;

namespace PosSystem
{
    internal class FilterDataGrid
    {
        public FilterDataGrid(DataGridView dataGridView, string textToKeep)
        {
            //int loopNum = dataGridView.Rows.Count;
            //for (int i = 0; i < dataGridView.RowCount; i++)
            //    if (dataGridView.Rows[i].Cells[1].Value.ToString().Trim() != textToKeep)
            //        dataGridView.Rows.RemoveAt(i);

            for (int i = dataGridView.RowCount - 1; i >= 0; i--)
            {
                var row = dataGridView.Rows[i];
                if (!row.IsNewRow && dataGridView.Rows[i].Cells[1].Value.ToString().Trim() != textToKeep)
                {
                    dataGridView.Rows.Remove(row);
                }
            }
        }
    }
}