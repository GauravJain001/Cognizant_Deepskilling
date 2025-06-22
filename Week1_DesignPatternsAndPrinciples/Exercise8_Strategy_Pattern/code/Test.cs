using System;
namespace code
{
    class Test
    {
        public static void Main(String[] args)
        {
            //Creating Strategies
            PaymentStrategy CreditCardStrategy = new CreditCardPayment();
            PaymentStrategy PayPalStrategy = new PayPalPayment();

            //creating context/client with CreditCardStrategy
            PaymentContext context1 = new PaymentContext(CreditCardStrategy);
            context1.ExecuteStrategy();

            //creating context with PayPalStrategy
            PaymentContext context2 = new PaymentContext(PayPalStrategy);
            context2.ExecuteStrategy();
        }
    }
}