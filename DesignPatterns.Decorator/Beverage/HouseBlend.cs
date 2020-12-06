namespace DesignPatterns.Decorator
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost() => .89;
    }
}
