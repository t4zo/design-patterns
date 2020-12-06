using System;

namespace DesignPatterns.Decorator
{
    class Program
    {
        private static void Main()
        {
            Beverage espresso = new Espresso();
            Console.WriteLine($"{espresso.Description} ${espresso.Cost()}");

            Beverage houseBlend = new HouseBlend();
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Mocha(houseBlend);
            Console.WriteLine($"{houseBlend.Description} ${houseBlend.Cost()}");
        }
    }
}
