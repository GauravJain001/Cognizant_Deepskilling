using System;
namespace code
{
    class PayPalAdapter : PaymentProcessor
    {
        private PayPal ?payPal;
        public PayPalAdapter(PayPal payPal)
        {
            this.payPal = payPal;
        }
        public void ProcessPayment(float amount)
        {
            if (payPal != null)
            {
                payPal.MakePayment(amount);
            }

        }
        
    }
}