using System;
using SingletonPattern;

namespace Test
{
    class Test
    {
        public static void Main(string[] args)
        {
            Singleton s1 = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();
            if (s1 == s2)
            {
                Console.WriteLine("Same Single Instance");
            }
            else
            {
                Console.WriteLine("Different Instance");
            }
        }
    }
    
}