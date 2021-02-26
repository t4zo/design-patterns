using System;

namespace DesignPatterns.Factory.Styles
{
    internal class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Granted Reggiano Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into circle slices");
        }
    }
}