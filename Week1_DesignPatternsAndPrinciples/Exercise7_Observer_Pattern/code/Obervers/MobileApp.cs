using System;
namespace code
{
    class MobileApp : code.Observer
    {
        private float stockPrice;
        private StockMarket stockMarket;
        public void Update()
        {
            if (stockMarket != null)
            {
                this.stockPrice = stockMarket.GetStockPrice();
            }
        }
        public MobileApp(StockMarket sm)
        {
            this.stockMarket = sm;
        }
        public float StockPrice()
        {
            return stockPrice;
            
        }
        
    }
}