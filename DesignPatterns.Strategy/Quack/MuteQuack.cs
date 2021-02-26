using System;

namespace DesignPatterns.Strategy.Interfaces.Quack
{
    internal class MuteQuack : IQuackBehavior
    {
        public void MakeQuack()
        {
            Console.WriteLine("MMMMMMM...");
        }
    }
}