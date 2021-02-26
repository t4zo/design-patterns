namespace DesignPatterns.Decorator
{
    interface IBeverage
    {
        public string Description { get; set; }

        public double Cost();
    }
}