using System;
using DesignPatterns.Factory.Styles;

namespace DesignPatterns.Factory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var nyPizzaStore = new NYStylePizzaStore();
            var nyPizza = nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {nyPizza.Name}");

            Console.WriteLine();

            var chicagoPizzaStore = new ChicagoStylePizzaStore();
            var chicagoPizza = chicagoPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {chicagoPizza.Name}");
        }
    }
}