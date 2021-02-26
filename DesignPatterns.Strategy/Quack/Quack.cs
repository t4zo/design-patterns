using System;

namespace DesignPatterns.Strategy.Interfaces.Quack
{
    internal class Quack : IQuackBehavior
    {
        public void MakeQuack()
        {
            Console.WriteLine("Quack!");
        }
    }
}