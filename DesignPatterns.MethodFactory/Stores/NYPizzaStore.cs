using DesignPatterns.MethodFactory.Styles;

namespace DesignPatterns.MethodFactory.Stores
{
    internal class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            var typeSanitized = type.ToLower();
            Pizza pizza = null;

            if (typeSanitized.Equals("cheese"))
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (typeSanitized.Equals("greek"))
            {
                pizza = new NYStyleGreekPizza();
            }
            else if (typeSanitized.Equals("pepperoni"))
            {
                pizza = new NYStylePepperoniPizza();
            }
            else if (typeSanitized.Equals("clam"))
            {
                pizza = new NYStyleClamPizza();
            }
            else if (typeSanitized.Equals("veggie"))
            {
                pizza = new NYStyleVeggiePizza();
            }

            return pizza;
        }
    }
}