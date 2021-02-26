using System;
using DesignPatterns.MethodFactory.Stores;

namespace DesignPatterns.MethodFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var nyStore = new NYPizzaStore();
            nyStore.OrderPizza("Cheese");

            Console.WriteLine();

            var chicagoStore = new ChicagoPizzaStore();
            chicagoStore.OrderPizza("Cheese");
        }
    }
}