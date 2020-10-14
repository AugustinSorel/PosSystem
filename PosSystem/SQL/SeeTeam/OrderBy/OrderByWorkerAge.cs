using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PosSystem
{
    class OrderByWorkerAge : SqlQueries
    {
        public OrderByWorkerAge(DataGridView dataGridView)
        {
            List<int> unsorted = new List<int>();
            List<int> sorted;

            for (int i = 0; i < dataGridView.Rows.Count; i++)
                 unsorted.Add(int.Parse(dataGridView.Rows[i].Cells[3].Value.ToString()));
           
            sorted = MergeSort(unsorted);

            for (int i = 0; i < unsorted.Count; i++)
            {
                dataGridView[3, i].Value = sorted[i];
            }

            dataGridView.Columns["WorkerID"].Visible = false;
            dataGridView.Columns["WorkerSurname"].Visible = false;
            dataGridView.Columns["WorkerPhoto"].Visible = false;
            dataGridView.Columns["Gender"].Visible = false;
        }

        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}