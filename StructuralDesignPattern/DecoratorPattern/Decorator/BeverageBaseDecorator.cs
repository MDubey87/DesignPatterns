using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    /// <summary>
    /// Decorator base class
    /// </summary>
    public abstract class BeverageBaseDecorator : IBeverage
    {
        protected IBeverage _beverage;

        public BeverageBaseDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public virtual string GetDescription()
        {
            return _beverage.GetDescription();
        }

        public virtual double Cost()
        {
            return _beverage.Cost();
        }
    }
}
