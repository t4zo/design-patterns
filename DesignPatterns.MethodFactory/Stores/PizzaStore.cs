namespace DesignPatterns.MethodFactory
{
    public abstract class PizzaStore
    {
        //private SimplePizzaFactory _factory { get; set; }

        //public PizzaStore(SimplePizzaFactory factory)
        //{
        //    _factory = factory;
        //}

        public abstract Pizza CreatePizza(string type);

        public virtual Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}