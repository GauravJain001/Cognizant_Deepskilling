public class PaymentContext {
    protected PaymentStrategy paymentStrategy;
    public PaymentContext(PaymentStrategy paymentStrategy){
        this.paymentStrategy = paymentStrategy;

    }
    public void pay(int amount){
        paymentStrategy.pay(amount);
    }
}