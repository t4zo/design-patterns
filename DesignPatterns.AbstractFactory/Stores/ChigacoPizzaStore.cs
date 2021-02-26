using DesignPatterns.Factory.Entities;

namespace DesignPatterns.Factory.Stores
{
    internal class ChicagoPizzaStore : PizzaStore
    {
        //public ChicagoPizzaStore(SimplePizzaFactory factory) : base(factory)
        //{
        //}
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza;

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
            else
            {
                pizza = new CheesePizza();
            }

            return pizza;
        }
    }
}