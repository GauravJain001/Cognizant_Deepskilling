using System;
namespace code
{
    class SortUtility
    {
        public static void BubbleSort(List<Order> orders)
        {
            int n = orders.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                    {
                        var temp = orders[j];
                        orders[j] = orders[j + 1];
                        orders[j + 1] = temp;
                    }
                }
            }
        }
        public static void QuickSort(List<Order> orders, int low, int high)
        {
            if (low < high)
            {
                int pivot = SortUtility.Partition(orders,low,high);
                SortUtility.QuickSort(orders, low, pivot-1);
                SortUtility.QuickSort(orders, pivot + 1, high);
                
            }

        }
        private static int Partition(List<Order> orders,int low,int high)
        {
            double pivot = orders[high].TotalPrice;
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (orders[j].TotalPrice <= pivot)
                {
                    i++;
                    Order temp = orders[i];
                    orders[i] = orders[j];
                    orders[j] = temp;
                }
            }

            Order temp2 = orders[i + 1];
            orders[i + 1] = orders[high];
            orders[high] = temp2;

            return i + 1;
        }



    }
    
}