public interface Stock {
    public void registerObserver(Observer o);
    public void deregisterObserver(Observer o);
    public void notifyObserver();

}
