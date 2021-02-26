using System;

namespace DesignPatterns.Strategy.Interfaces.Fly
{
    internal class FlyWithHings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings!");
        }
    }
}