public class CreditCardPayment implements PaymentStrategy{
    @Override
    public void pay(int amount){
        System.out.println("Payment using Credit Card " + amount);
    }
}
