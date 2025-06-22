using System;

namespace code
{
    interface PaymentProcessor
    {
        public void ProcessPayment(float amount);
    }
}