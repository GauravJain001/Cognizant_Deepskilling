using System;
namespace code
{
    class Product
    {
        public int productId;
        public string productName;
        public int quantity;
        public int price;
        public Product(int productId, string productName, int quantity, int price)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
            this.productId = productId;
        }

        public override string ToString()
        {
            return $"ProductID: {this.productId} ProductName: {this.productName} quantity: {this.quantity} price: {this.price}";
        }
        
    }
}