public class PayPalPayment implements PaymentStrategy{
    @Override
    public void pay(int amount){
        System.out.println("Payment using PayPal " + amount);
    }
}
