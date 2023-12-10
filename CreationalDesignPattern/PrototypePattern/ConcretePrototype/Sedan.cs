using PrototypePattern.Prototype;

namespace PrototypePattern.ConcretePrototype
{
    public class Sedan : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public ICar Clone()
        {
            return (ICar)this.MemberwiseClone();
        }
    }
}
