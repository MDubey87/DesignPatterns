namespace FactoryMethodDesignPatternDemo.Product
{
    public class Coffee : IBeverage
    {
        public string Serve()
        {
            return "Serving Coffee";
        }
    }
}
