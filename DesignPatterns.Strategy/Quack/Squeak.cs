using System;

namespace DesignPatterns.Strategy.Interfaces.Quack
{
    internal class Squeak : IQuackBehavior
    {
        public void MakeQuack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
