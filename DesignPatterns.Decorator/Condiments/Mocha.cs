namespace DesignPatterns.Decorator
{
    class Mocha : ICondimentDecorator
    {
        private readonly IBeverage _beverage;
        public string Description { get; set; }

        public Mocha(IBeverage beverage)
        {
            _beverage = beverage;
            Description += $"{_beverage.Description}, Mocha";
        }

        public double Cost()
        {
            return .20 + _beverage.Cost();
        }
    }
}