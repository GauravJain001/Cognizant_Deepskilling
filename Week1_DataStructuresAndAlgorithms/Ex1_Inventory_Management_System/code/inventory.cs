using System;
using System.Collections.Generic;
namespace code
{
    //making a singleton inventory class 
    // it has add,update,delete,get methods 
    // store is implemented using Dictionary which is best for access 
    // tc of o(1) amortized 
    class Inventory
    {
        private Dictionary<int, Product> store;
        private static Inventory ?instance = null;
        public void add(Product p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            store.Add(p.productId, p);
        }
        public void update(Product p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            if (store.TryGetValue(p.productId, out Product? oldProduct))
            {
                Console.WriteLine("Old Value: " + oldProduct.ToString());
            }
            else
            {
                Console.WriteLine("No existing product found with ID " + p.productId);
            }
            store[p.productId] = p;
            Console.WriteLine("new Value :" + p.ToString());
        }
        public void get(int productId)
        {
            if (store.TryGetValue(productId, out Product ?p))
            {
                Console.WriteLine(p.ToString());
            }
            else
            {
                Console.WriteLine($"Product by id {productId} Not Found");
            }
        }
        public void delete(int productId)
        {
            if (store.TryGetValue(productId, out Product ?p))
            {
                store.Remove(productId);
                Console.WriteLine($"Delete product id {productId} successfully");
            }
            else
            {
                Console.WriteLine("Product Not found");
            }
        }
        private Inventory()
        {
            store = new Dictionary<int, Product>();
        }


        public static Inventory getInstance()
        {
            if (instance == null)
            {
                instance = new Inventory();
            }
            return instance;

        }
        public List<Product> GetAllProducts()
        {
            return store.Values.ToList();
        }



    }
}