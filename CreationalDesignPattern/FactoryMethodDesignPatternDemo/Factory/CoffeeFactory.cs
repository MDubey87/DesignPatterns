using FactoryMethodDesignPatternDemo.Product;

namespace FactoryMethodDesignPatternDemo.Factory
{
    public class CoffeeFactory : IBeverageFactory
    {
        public IBeverage createBeverage()
        {
            return new Coffee();
        }
    }
}
