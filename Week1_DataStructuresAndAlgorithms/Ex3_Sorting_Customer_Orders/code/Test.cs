using System;
namespace code
{
    class Test
    {
        public static void Main(String []args)
        {
            List<Order> orders = new List<Order>
            {
                new Order(1, "Gaurav", 2500),
                new Order(2, "Ram", 1200),
                new Order(3, "Sam", 5000),
                new Order(4, "Mohan", 800)
            };
            Console.WriteLine("Before Sorting");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
            SortUtility.QuickSort(orders, 0, orders.Count - 1);
            //Tc-O(nlogn) for avg and best O(n^2) for worst

            Console.WriteLine("\nAfter Sorting QuickSort");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }

            Console.WriteLine("ReSuffling");
            orders = new List<Order>
            {
                new Order(1, "Gaurav", 2500),
                new Order(2, "Ram", 1200),
                new Order(3, "Sam", 5000),
                new Order(4, "Mohan", 800)
            };
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
            //TC- O(n^2)
            Console.WriteLine("\nAfter Sorting BubbleSort");
            SortUtility.BubbleSort(orders);
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }


        }
    }
}