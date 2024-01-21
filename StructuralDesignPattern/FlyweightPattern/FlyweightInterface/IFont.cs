namespace FlyweightPattern.FlyweightInterface
{
    /// <summary>
    /// Flyweight interface
    /// </summary>
    public interface IFont
    {
        void SetSize(int size);
        void SetStyle(string style);
        void SetColor(string color);
        void Display(string text);
    }
}
