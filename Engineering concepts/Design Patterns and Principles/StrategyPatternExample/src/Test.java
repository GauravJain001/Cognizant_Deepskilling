public class Test {
    public static void main(String [] args){
        // Initilizing strategies
        PaymentStrategy CreditCardPaymentStrategy = new CreditCardPayment();
        PaymentStrategy PayPalPaymentStrategy = new PayPalPayment();

        // initilazing the client with strategy-credit card
        PaymentContext paymentContext = new PaymentContext(CreditCardPaymentStrategy);
        paymentContext.pay(100);

        //initilizing the client with strategy with paypal
        paymentContext = new PaymentContext(PayPalPaymentStrategy);
        paymentContext.pay(10);

    }
}
