using System;
namespace code
{
    class CreditCardPayment : PaymentStrategy
    {
        public void Pay()
        {
            Console.WriteLine("Payed Using CreditCard");
            
        }
    }
}