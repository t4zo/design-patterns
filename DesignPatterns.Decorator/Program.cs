using System;

namespace DesignPatterns.Decorator
{
    internal class Program
    {
        private static void Main()
        {
            IBeverage espresso = new Espresso();
            Console.WriteLine($"{espresso.Description} ${espresso.Cost()}");

            IBeverage houseBlend = new HouseBlend();
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Mocha(houseBlend);
            Console.WriteLine($"{houseBlend.Description} ${houseBlend.Cost()}");
        }
    }
}