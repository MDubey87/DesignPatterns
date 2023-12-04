using FactoryMethodDesignPatternDemo.Product;

namespace FactoryMethodDesignPatternDemo.Factory
{
    public class TeaFactory : IBeverageFactory
    {
        public IBeverage createBeverage()
        {
            return new Tea();
        }
    }
}
