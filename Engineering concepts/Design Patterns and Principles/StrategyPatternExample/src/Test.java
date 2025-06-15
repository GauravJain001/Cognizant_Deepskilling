public class Test {
    public static void main(String [] args){
        // Initilizing strategies
        PaymentStrategy CreditCardPaymentStrategy = new CreditCardPayment();
        PaymentStrategy PayPalPaymentStrategy = new PayPalPayment();

        // initilazing the client with strategy credit card
        PaymentContext paymentContext1 = new PaymentContext(CreditCardPaymentStrategy);
        paymentContext1.pay(100);

        //initilizing the client with strategy paypal
        PaymentContext paymentContext2 = new PaymentContext(PayPalPaymentStrategy);
        paymentContext2.pay(10);

    }
}
