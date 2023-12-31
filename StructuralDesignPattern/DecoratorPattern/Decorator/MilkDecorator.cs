using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    /// <summary>
    /// Concrete decorator adding milk to the beverage
    /// </summary>
    public class MilkDecorator : BeverageBaseDecorator
    {
        public MilkDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Milk";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.5; // Milk costs 0.5
        }
    }
}
