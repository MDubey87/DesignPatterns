namespace AbstractFactoryPatternExample.Product.TextBox
{
    public class WindowTextBox:ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Render window textbox");
        }
    }
}
