using System;
namespace code
{
    class Test
    {
        public static void Main(String[] args)
        {
            //creating 3rd party objects
            PayPal payPal = new PayPal();
            Visa visa = new Visa();
            //creating Adapters
            PaymentProcessor payPalAdapter = new PayPalAdapter(payPal);
            PaymentProcessor visaAdapter = new VisaAdapter(visa);
            //making payment
            payPalAdapter.ProcessPayment(100);
            visaAdapter.ProcessPayment(200);
            

        }
    }
}