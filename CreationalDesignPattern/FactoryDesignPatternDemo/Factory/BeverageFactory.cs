using FactoryDesignPatternDemo.Product;

namespace FactoryDesignPatternDemo.Factory
{
    public class BeverageFactory
    {        
        public static IBeverage GetBeverage(string beverageName)
        {
            IBeverage beverage = null;
            if (beverageName == "Coffee")
            {
                beverage = new Coffee();
            }
            else if (beverageName == "Tea")
            {
                beverage = new Tea();
            }
            return beverage;
        }
    }
}
