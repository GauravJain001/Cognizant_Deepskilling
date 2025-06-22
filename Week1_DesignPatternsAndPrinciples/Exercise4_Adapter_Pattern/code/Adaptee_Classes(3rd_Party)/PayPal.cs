using System;
namespace code
{
    class PayPal
    {
        public void MakePayment(float amount)
        {
            Console.WriteLine("Payment using PayPal:" + amount);
        }
    }
}