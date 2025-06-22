using System;
namespace code
{
    public class Product
    {
        public int Id;
        public string Name;
        public string Category;

        public Product(int productId, string name, string category)
        {
            Id = productId;
            Name = name;
            Category = category;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Category: {Category}";
        }
    }

    
}
