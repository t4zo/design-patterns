namespace DesignPatterns.Decorator
{
    class HouseBlend : IBeverage
    {
        public string Description { get; set; }

        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public double Cost()
        {
            return .89;
        }
    }
}