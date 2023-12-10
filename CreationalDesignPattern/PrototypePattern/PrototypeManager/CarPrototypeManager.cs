using PrototypePattern.Prototype;

namespace PrototypePattern.PrototypeManager
{
    public class CarPrototypeManager
    {
        private Dictionary<string, ICar> _prototypes;
        public CarPrototypeManager()
        {
            _prototypes = new Dictionary<string, ICar>();
        }
        public ICar GetPrototype(string key)
        {
            return _prototypes[key].Clone();
        }
        public void AddPrototype(string key, ICar prototype)
        {
            _prototypes.Add(key, prototype);
        }
    }
}
