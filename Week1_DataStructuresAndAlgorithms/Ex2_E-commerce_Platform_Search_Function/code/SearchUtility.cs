using System;
namespace code
{
    class SearchUtility
    {
        //Tc - o(N)
        public static Product? LinearSearch(List<Product> Products, String name)
        {
            foreach (var product in Products)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }
        //TC- O(logn)
        public static Product? BinarySearch(List<Product> Products, String name)
        {
            int left = 0;
            int right = Products.Count() - 1;
            Products.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            while (left <= right)
            {
                int mid = (left + right) / 2;
                int res = string.Compare(Products[mid].Name, name, true);
                if (res == 0)
                {
                    return Products[mid];
                }
                else if (res < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return null;
        }
    }
}