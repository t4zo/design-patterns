namespace DesignPatterns.Decorator
{
    abstract class Beverage
    {
        public string Description { get; set; }

        public abstract double Cost();
    }
}
