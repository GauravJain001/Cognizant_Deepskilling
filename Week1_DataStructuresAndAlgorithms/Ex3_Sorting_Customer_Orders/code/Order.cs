using System;

namespace code
{
    class Order
    {
        public int Id;
        public string CustomerName;
        public double TotalPrice;

        public Order(int id, string name, double price)
        {
            Id = id;
            CustomerName = name;
            TotalPrice = price;
        }

        public override string ToString()
        {
            return $"OrderID: {Id}, Name: {CustomerName}, Total: ₹{TotalPrice}";
        }
    }
}
