using VisitorPattern.Element;

namespace VisitorPattern.Visitor
{
    /// <summary>
    /// Concrete Visitor2
    /// </summary>
    public class PerimeterVisitor : IVisitor
    {
        public double TotalPerimeter { get; private set; }

        public void Visit(Circle circle)
        {
            TotalPerimeter += 2 * Math.PI * circle.Radius;
        }

        public void Visit(Rectangle rectangle)
        {
            TotalPerimeter += 2 * (rectangle.Width + rectangle.Height);
        }

        public void Visit(Triangle triangle)
        {
            // Assuming it's an equilateral triangle for simplicity
            TotalPerimeter += 3 * triangle.Base;
        }
    }
}
