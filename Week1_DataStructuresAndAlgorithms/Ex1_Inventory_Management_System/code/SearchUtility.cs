using System;
using System.Collections.Generic;

//utility class for generic Linear search and binary search for product id

namespace code
{
    class SearchUtility
    {
        public static List<Product> LinearSearch(List<Product> store, Func<Product, bool> match)
        {
            List<Product> ans = new();
            foreach (var p in store)
            {
                if (match(p))
                {
                    ans.Add(p);
                }
            }
            return ans;
        }
        public static Product BinarySearch(List<Product> store, int productId)
        {

            store.Sort((a, b) => a.productId.CompareTo(b.productId));
            int left = 0;
            int right = store.Count()-1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (store[mid].productId == productId)
                {
                    return store[mid];
                }
                else if (store[mid].productId < productId)
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