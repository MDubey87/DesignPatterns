namespace PrototypePattern.Prototype
{
    public interface ICar
    {
        string Model { get; set; }
        string Color { get; set; }
        int Price { get; set; }
        public ICar Clone();
    }
}
