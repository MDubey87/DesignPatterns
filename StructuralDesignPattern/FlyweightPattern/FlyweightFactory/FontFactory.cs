using FlyweightPattern.ConcreteFlyweight;
using FlyweightPattern.FlyweightInterface;

namespace FlyweightPattern.FlyweightFactory
{
    /// <summary>
    /// Flyweight Factory
    /// </summary>
    public class FontFactory
    {
        private Dictionary<string, IFont> fonts = new Dictionary<string, IFont>();
        public IFont GetFont(string key)
        {
            if (!fonts.ContainsKey(key))
            {
                fonts[key] = new ConcreteFont();
            }
            return fonts[key];
        }
    }
}
