using FactoryMethodDesignPatternDemo.Product;

namespace FactoryMethodDesignPatternDemo.Factory
{
    public  interface IBeverageFactory
    {
        public IBeverage createBeverage();
    }
}
