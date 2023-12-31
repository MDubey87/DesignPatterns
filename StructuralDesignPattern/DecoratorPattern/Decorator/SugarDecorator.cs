using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    /// <summary>
    /// Concrete decorator adding sugar to the beverage
    /// </summary>
    public class SugarDecorator : BeverageBaseDecorator
    {
        public SugarDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Sugar";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.2; // Sugar costs 0.2
        }
    }
}
