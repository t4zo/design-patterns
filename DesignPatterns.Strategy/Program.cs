using DesignPatterns.Strategy.Fly;

namespace DesignPatterns.Strategy
{
    internal class Program
    {
        private static void Main()
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.PerformFly();
            mallardDuck.SetFlyBehavior(new FlyRocketPowered());
            mallardDuck.PerformFly();
        }
    }
}