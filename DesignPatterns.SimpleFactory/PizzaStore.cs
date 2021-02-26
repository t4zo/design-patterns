namespace DesignPatterns.SimpleFactory
{
    public class PizzaStore
    {
        public PizzaStore(SimplePizzaFactory factory)
        {
            _factory = factory;
        }

        private SimplePizzaFactory _factory { get; }

        public virtual Pizza OrderPizza(string type)
        {
            var pizza = _factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}