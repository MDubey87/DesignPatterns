namespace AbstractFactoryPatternExample.Product.TextBox
{
    public class MacTextBox:ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Render mac textbox");
        }
    }
}
