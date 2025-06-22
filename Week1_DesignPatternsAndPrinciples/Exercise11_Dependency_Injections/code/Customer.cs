using System;
namespace code
{
    class Customer
    {
        public int Id;
        public string name;
        public Customer(int Id, string name)
        {
            this.name = name;
            this.Id = Id;
        }
        public override string ToString()
        {
            return $"Customer ID: {Id}, Name: {name}";
        }
    }
}