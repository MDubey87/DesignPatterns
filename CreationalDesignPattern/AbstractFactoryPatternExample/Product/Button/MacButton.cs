namespace AbstractFactoryPatternExample.Product.Button
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render mac button");
        }
    }
}
