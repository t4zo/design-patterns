using DesignPatterns.Factory.Entities;

namespace DesignPatterns.Factory.Stores
{
    internal class NYPizzaStore : PizzaStore
    {
        //public NYPizzaStore(SimplePizzaFactory factory) : base(factory)
        //{
        //}

        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("greek"))
            {
                pizza = new GreekPizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza();
            }

            return pizza;
        }
    }
}