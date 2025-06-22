using System;
namespace code
{
    class PaymentContext
    {
        private PaymentStrategy Strategy;
        public PaymentContext(PaymentStrategy Strategy)
        {
            this.Strategy = Strategy;
        }
        public void ExecuteStrategy()
        {
            Strategy.Pay();
        }
    }
}