using CompositeDesignPattern.Composite;
using CompositeDesignPattern.Leaf;

// Create individual employees
var employee1 = new Employee("Alice", "Manager");
var employee2 = new Employee("Bob", "Developer");
var employee3 = new Employee("Charlie", "Designer");

// Create a group and add employees to it
var group1 = new EmployeeGroup();
group1.AddEmployee(employee1);
group1.AddEmployee(employee2);

var group2 = new EmployeeGroup();
group2.AddEmployee(employee3);

// Create a larger group and add the previously created groups to it
var largerGroup = new EmployeeGroup();
largerGroup.AddEmployee(group1);
largerGroup.AddEmployee(group2);

// Display details of the larger group, which recursively displays all employees
largerGroup.DisplayDetails();
Console.ReadKey();