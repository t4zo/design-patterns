using System;

namespace DesignPatterns.Strategy.Interfaces.Fly
{
    internal class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly :(");
        }
    }
}
