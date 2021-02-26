using DesignPatterns.MethodFactory.Styles;

namespace DesignPatterns.MethodFactory.Stores
{
    internal class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            var typeSanitized = type.ToLower();
            Pizza pizza = null;

            if (typeSanitized.Equals("cheese"))
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (typeSanitized.Equals("greek"))
            {
                pizza = new ChicagoStyleGreekPizza();
            }
            else if (typeSanitized.Equals("pepperoni"))
            {
                pizza = new ChicagoStylePepperoniPizza();
            }
            else if (typeSanitized.Equals("clam"))
            {
                pizza = new ChicagoStyleClamPizza();
            }
            else if (typeSanitized.Equals("veggie"))
            {
                pizza = new ChicagoStyleVeggiePizza();
            }

            return pizza;
        }
    }
}