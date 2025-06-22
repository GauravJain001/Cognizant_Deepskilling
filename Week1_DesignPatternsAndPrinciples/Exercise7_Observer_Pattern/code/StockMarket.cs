using System;

namespace code
{
    class StockMarket : Stock
    {
        private List<Observer> ObserverList;
        private float StockPrice;
        public void Register(Observer o)
        {
            ObserverList.Add(o);
        }
        public void DeRegister(Observer o)
        {
            ObserverList.Remove(o);
        }
        public void Notify()
        {
            foreach (var o in ObserverList)
            {
                o.Update();
            }

        }
        public void SetStockPrice(float amount)
        {
            this.StockPrice = amount;
            
        }
        public float GetStockPrice()
        {
            return this.StockPrice;
        }
        public StockMarket()
        {
            ObserverList = new List<Observer>();
        }

    }
}