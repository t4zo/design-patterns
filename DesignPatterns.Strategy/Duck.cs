using System;

namespace DesignPatterns.Strategy
{
    internal abstract class Duck
    {
        private IFlyBehavior _flyBehabior;
        private IQuackBehavior _quackBehavior;

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            _flyBehabior = flyBehavior;
            _quackBehavior = quackBehavior;
        }

        public virtual void Swin()
        {
            Console.WriteLine("I'm swimming");
        }

        public abstract void Display();

        public virtual void PerformFly()
        {
            _flyBehabior.Fly();
        }

        public virtual void PerformQuack()
        {
            _quackBehavior.MakeQuack();
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehabior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }
    }
}
