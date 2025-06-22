using System;
namespace code
{
    class Test
    {
        public static void Main(String[] args)
        {
            //instancing Inventory (singleton pattern)
            Inventory store = Inventory.getInstance();

            //Making Products List
            List<Product> products = [
            new Product(1, "Mouse", 50, 500),
            new Product(2, "Keyboard", 30, 700),
            new Product(3, "Monitor", 15, 8000),
            new Product(4, "CPU", 10, 20000),
            new Product(5, "GPU", 5, 50000),
            new Product(6, "RAM 8GB", 25, 2500),
            new Product(7, "RAM 16GB", 15, 4500),
            new Product(8, "SSD 256GB", 20, 3000),
            new Product(9, "SSD 512GB", 18, 5000),
            new Product(10, "HDD 1TB", 12, 4000),
            new Product(11, "Laptop", 8, 55000),
            new Product(12, "Tablet", 10, 25000),
            new Product(13, "Smartphone", 20, 30000),
            new Product(14, "Printer", 6, 10000),
            new Product(15, "Router", 10, 2500),
            new Product(16, "Webcam", 14, 1800),
            new Product(17, "Microphone", 9, 2200),
            new Product(18, "Headphones", 20, 1500),
            new Product(19, "Speakers", 12, 3500),
            new Product(20, "Projector", 3, 45000)
            ];

            //Inserting Products in Store
            foreach (var p in products)
            {
                store.add(p);
            }

            //testing get,update,delete methods
            store.delete(20);
            store.get(20);
            store.update(new Product(1, "Mouse", 60, 500));
            store.get(15);
            store.get(2);



            //Testing LinearSearch and BinarySearch Utility
            //all products whose quantity is greater then 50
            List<Product> res = SearchUtility.LinearSearch(store.GetAllProducts(), p => p.quantity >= 20);
            Console.WriteLine("\nPRoducts with quantity >= 20");
            foreach (var p in res)
            {
                Console.WriteLine(p.ToString());
            }
            //Binary Search by Id
            // when id exits
            Console.WriteLine("\nBinary Search Result");
            Product p1 = SearchUtility.BinarySearch(store.GetAllProducts(), 4);
            Console.WriteLine(p1);
            //when id does not exists
            Product p2 = SearchUtility.BinarySearch(store.GetAllProducts(), 20);
            Console.WriteLine(p2);



            



            
        }
    }
}