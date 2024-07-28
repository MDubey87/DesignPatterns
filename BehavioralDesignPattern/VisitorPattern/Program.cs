using VisitorPattern.Element;
using VisitorPattern.Visitor;

List<IShape> shapes = new List<IShape>
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Triangle(3, 4)
        };

AreaVisitor areaVisitor = new AreaVisitor();
PerimeterVisitor perimeterVisitor = new PerimeterVisitor();

foreach (var shape in shapes)
{
    shape.Accept(areaVisitor);
    shape.Accept(perimeterVisitor);
}

Console.WriteLine($"Total Area: {areaVisitor.TotalArea}");
Console.WriteLine($"Total Perimeter: {perimeterVisitor.TotalPerimeter}");
Console.ReadLine();