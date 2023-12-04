namespace AbstractFactoryPatternExample.Product.Button
{
    public class WindowButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render window button");
        }
    }
}
