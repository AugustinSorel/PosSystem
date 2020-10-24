using System.Collections.Generic;
using System.Linq;

namespace PosSystem
{
    class GraphBubbleSort
    {
        public static List<float> GetListSorted(List<float> unsortedList)
        {
            List<float> SortedMoneyPerDay = unsortedList.ToList();
            for (int i = 0; i < SortedMoneyPerDay.Count; i++)
            {
                for (int j = 0; j < SortedMoneyPerDay.Count - 1; j++)
                {
                    if (SortedMoneyPerDay[j] > SortedMoneyPerDay[j + 1])
                    {
                        float temp = SortedMoneyPerDay[j + 1];
                        SortedMoneyPerDay[j + 1] = SortedMoneyPerDay[j];
                        SortedMoneyPerDay[j] = temp;
                    }
                }
            }


            return SortedMoneyPerDay;
        }
    }
}
