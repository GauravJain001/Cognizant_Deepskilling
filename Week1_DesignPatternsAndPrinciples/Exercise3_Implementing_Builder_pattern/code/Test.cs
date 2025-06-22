using System;
namespace code
{
    class Test
    {
        public static void Main(String[] args)
        {
            Computer Pc1 = new Computer.Builder()
            .WithCpu("Intel")
            .WithRam("90 GB")
            .WithStorage("100 TB")
            .Build();
            Console.WriteLine(Pc1);

            Computer Pc2 = new Computer.Builder()
            .WithCpu("Rizen")
            .WithStorage("10TB")
            .WithRam("10GB")
            .Build();
            Console.WriteLine(Pc2);
        }
    }
}