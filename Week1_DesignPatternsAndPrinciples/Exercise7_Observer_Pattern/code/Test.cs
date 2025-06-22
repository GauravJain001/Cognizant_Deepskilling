using System;
namespace code
{
    class Test
    {
        public static void Main(String[] args)
        {
            //creating subject
            StockMarket stockMarket = new StockMarket();
            //creating Observers
            WebApp webApp = new WebApp(stockMarket);
            MobileApp mobileApp = new MobileApp(stockMarket);
            //Adding observers to oberverList
            stockMarket.Register(mobileApp);
            stockMarket.Register(webApp);
            //setting amount
            stockMarket.SetStockPrice(100);
            //notifying observers
            stockMarket.Notify();
            // checking if updated in observers
            Console.WriteLine("MobileApp StockPrice - "+mobileApp.StockPrice());
            Console.WriteLine("WebApp StockPrice : "+webApp.StockPrice());
            //DeRegistering mobileApp
            stockMarket.DeRegister(mobileApp);
            Console.WriteLine("Deregister MobileApp");
            Console.WriteLine("Update Stock PRice to 50");
            //updating stock price
            stockMarket.SetStockPrice(50);
            stockMarket.Notify();
            //checking updates mobile app will not be updated as it had deregistered
            Console.WriteLine("MobileApp StockPrice - "+mobileApp.StockPrice());
            Console.WriteLine("WebApp StockPrice : "+webApp.StockPrice());
            
        }
    }
}