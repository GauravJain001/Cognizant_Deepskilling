using System;
namespace code
{
    class Test
    {
        public static void Main(String[] args)
        {
            List<Product> ProductList = new List<Product>
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Phone", "Electronics"),
                new Product(103, "Shirt", "Clothing"),
                new Product(104, "Shoes", "Footwear"),
                new Product(105, "Watch", "Accessories")
            };
            Product? result1 = SearchUtility.LinearSearch(ProductList, "Laptop");
            if (result1 == null)
            {
                Console.WriteLine("Product Not FOund");
            }
            else
            {
                Console.WriteLine("Product Found" + result1);
            }
            Product? result2 = SearchUtility.BinarySearch(ProductList, "Shoes");
            if (result2 == null)
            {
                Console.WriteLine("Product Not FOund");
            }
            else
            {
                Console.WriteLine("Product Found" + result2);
            }
            Product ?result3 = SearchUtility.BinarySearch(ProductList, "Ring");
            if (result3 == null)
            {
                Console.WriteLine("Product Not FOund");
            }
            else
            {
                Console.WriteLine("Product Found" + result3);
            }

        }
    }
}