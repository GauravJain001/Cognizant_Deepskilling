using System;
namespace code
{
    class WebApp : Observer
    {
        private float stockPrice;
        StockMarket stockMarket;
        public void Update()
        {
            if (stockMarket != null)
            {
                this.stockPrice = stockMarket.GetStockPrice();
            }
        }
        public WebApp(StockMarket sm)
        {
            this.stockMarket = sm;
        }
        public float StockPrice()
        {
            return stockPrice;
            
        }
    }
}