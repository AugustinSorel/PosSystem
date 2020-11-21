using System.Collections.Generic;
using System.Windows.Forms;

namespace PosSystem
{
    internal class OrderByItemPrice : SqlQueries
    {
        public OrderByItemPrice(DataGridView dataGridView)
        {
            List<int> unsorted = new List<int>();
            List<int> sorted;

            for (int i = 0; i < dataGridView.Rows.Count; i++)
                unsorted.Add(int.Parse(dataGridView.Rows[i].Cells[6].Value.ToString()));

            sorted = GetBubbleSort(unsorted);

            for (int i = 0; i < unsorted.Count; i++)
                dataGridView[6, i].Value = sorted[i];

            dataGridView.Columns["ItemID"].Visible = false;
            dataGridView.Columns["Description"].Visible = false;
            dataGridView.Columns["SupplierID"].Visible = false;
            dataGridView.Columns["CategoryID"].Visible = false;
            dataGridView.Columns["PurchasePrice"].Visible = false;
            dataGridView.Columns["Coefficient"].Visible = false;
            dataGridView.Columns["VatID"].Visible = false;
            dataGridView.Columns["ProductPhoto"].Visible = false;
            dataGridView.Columns["StockMin"].Visible = false;
            dataGridView.Columns["StockMax"].Visible = false;
        }

        private List<int> GetBubbleSort(List<int> unsorted)
        {
            for (int write = 0; write < unsorted.Count; write++)
            {
                for (int sort = 0; sort < unsorted.Count - 1; sort++)
                {
                    if (unsorted[sort] < unsorted[sort + 1])
                    {
                        int temp = unsorted[sort + 1];
                        unsorted[sort + 1] = unsorted[sort];
                        unsorted[sort] = temp;
                    }
                }
            }

            return unsorted;
        }
    }
}