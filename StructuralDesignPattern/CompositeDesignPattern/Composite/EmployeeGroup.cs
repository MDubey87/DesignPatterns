using CompositeDesignPattern.ComponentInterface;

namespace CompositeDesignPattern.Composite
{
    /// <summary>
    /// Composite - Represents a group of employees
    /// </summary>
    public class EmployeeGroup : IEmployee
    {
        private readonly List<IEmployee> _employees = new List<IEmployee>();

        public void AddEmployee(IEmployee employee)
        {
            _employees.Add(employee);
        }

        public void DisplayDetails()
        {
            foreach (var employee in _employees)
            {
                employee.DisplayDetails();
            }
        }
    }
}
