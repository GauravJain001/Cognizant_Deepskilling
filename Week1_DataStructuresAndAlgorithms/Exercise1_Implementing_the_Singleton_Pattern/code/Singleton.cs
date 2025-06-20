using System;
namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance = null;
        private Singleton()
        {
            Console.WriteLine("Instance Created");
        }
        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}