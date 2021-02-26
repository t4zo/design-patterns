namespace DesignPatterns.SimpleFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var factory = new SimplePizzaFactory();
            var store = new PizzaStore(factory);
            store.OrderPizza("cheese");
        }
    }
}