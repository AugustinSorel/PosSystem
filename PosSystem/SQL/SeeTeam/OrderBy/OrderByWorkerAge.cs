using System.Data.OleDb;
using System.Windows.Forms;

namespace PosSystem
{
    class OrderByWorkerAge : SqlQueries
    {
        //public OrderByWorkerAge(DataGridView dataGridView)
        //{
        //    OleDbCommand oleDbCommand = CreateCommand();
        //    ExecuteCommand(oleDbCommand);
        //    dataGridView.DataSource = SetDataSource(oleDbCommand);
        //}

        //private OleDbCommand CreateCommand()
        //{
        //    OleDbCommand oleDbCommand = oleDbConnection.CreateCommand();
        //    oleDbCommand.CommandText = GetCommandText();
        //    return oleDbCommand;
        //}

        //private string GetCommandText()
        //{
        //    return "SELECT WorkerName, Age From WorkerDetails ORDER BY Age";
        //}
        public OrderByWorkerAge(DataGridView dataGridView)
        {
            int[] Age = new int[dataGridView.Rows.Count];
            int n = dataGridView.Rows.Count, i;

            for (i = 0; i < dataGridView.Rows.Count; i++)
                Age[i] = int.Parse(dataGridView.Rows[i].Cells[3].Value.ToString());

            mergeSort(Age, 0, n - 1);

            foreach (var age in Age)
            {
                MessageBox.Show(age.ToString());
            }

        }

        static public void merge(int[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[p + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        static public void mergeSort(int[] arr, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                mergeSort(arr, p, q);
                mergeSort(arr, q + 1, r);
                merge(arr, p, q, r);
            }
        }
    }
}