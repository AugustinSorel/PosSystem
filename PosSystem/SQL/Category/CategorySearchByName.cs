using System;
using System.Collections.Generic;

namespace PosSystem
{
    internal class CategorySearchByName
    {
        private static Category Category;
        private static readonly List<string> UnsortedList = new List<string>();

        internal static bool CheckIfNameExists(Category category)
        {
            Category = category;
            GetArray();
            int result = BinarySearch(UnsortedList, category.TxtBoxSearchName.Text);

            if (result == -1)
            {
                System.Windows.Forms.MessageBox.Show(category.TxtBoxSearchName.Text + " doesnt exists");
                return false;
            }
            else
                return true;
        }

        private static void GetArray()
        {
            for (int i = 0; i < Category.dataGridView1.Rows.Count; i++)
                UnsortedList.Add(Category.dataGridView1.Rows[i].Cells[1].Value.ToString().Trim());
        }

        private static  int BinarySearch(List<string> arr, String x)
        {
            int l = 0, r = arr.Count - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                int res = x.CompareTo(arr[m]);

                // Check if x is present at mid  
                if (res == 0)
                    return m;

                // If x greater, ignore left half  
                if (res > 0)
                    l = m + 1;

                // If x is smaller, ignore right half  
                else
                    r = m - 1;
            }

            return -1;
        }
    }

}