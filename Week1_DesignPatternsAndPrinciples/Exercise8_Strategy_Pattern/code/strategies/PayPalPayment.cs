using System;
namespace code
{
    class PayPalPayment : PaymentStrategy
    {
        public void Pay()
        {
            Console.WriteLine("Payed Using PayPal");
            
        }
    }
}