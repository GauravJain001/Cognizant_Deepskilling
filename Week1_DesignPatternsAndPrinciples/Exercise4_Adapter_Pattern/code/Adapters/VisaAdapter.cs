using System;
namespace code
{
    class VisaAdapter : PaymentProcessor
    {
        private Visa? visa;
        public VisaAdapter(Visa visa)
        {
            this.visa = visa;
        }
        public void ProcessPayment(float amount)
        {
            visa?.MakePayment(amount);
            
        }

    }
}