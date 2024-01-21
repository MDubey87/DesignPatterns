using FlyweightPattern.FlyweightInterface;

namespace FlyweightPattern.ConcreteFlyweight
{
    /// <summary>
    /// Concrete Flyweight
    /// </summary>
    public class ConcreteFont : IFont
    {
        private int size;
        private string style;
        private string color;

        public void SetSize(int size)
        {
            this.size = size;
        }

        public void SetStyle(string style)
        {
            this.style = style;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public void Display(string text)
        {
            Console.WriteLine($"Text: '{text}' | Size: {size} | Style: {style} | Color: {color}");
        }
    }
}
