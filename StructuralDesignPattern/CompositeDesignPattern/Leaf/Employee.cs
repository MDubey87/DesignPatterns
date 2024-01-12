using CompositeDesignPattern.ComponentInterface;

namespace CompositeDesignPattern.Leaf
{
    /// <summary>
    /// Leaf - Represents individual employees
    /// </summary>
    public class Employee : IEmployee
    {
        private readonly string _name;
        private readonly string _position;

        public Employee(string name, string position)
        {
            _name = name;
            _position = position;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee: {_name}, Position: {_position}");
        }
    }
}
