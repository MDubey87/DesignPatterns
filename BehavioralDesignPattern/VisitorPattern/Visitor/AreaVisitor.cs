using VisitorPattern.Element;

namespace VisitorPattern.Visitor
{
    /// <summary>
    /// Concrete Visitor1
    /// </summary>
    public class AreaVisitor : IVisitor
    {
        public double TotalArea { get; private set; }

        public void Visit(Circle circle)
        {
            TotalArea += Math.PI * circle.Radius * circle.Radius;
        }

        public void Visit(Rectangle rectangle)
        {
            TotalArea += rectangle.Width * rectangle.Height;
        }

        public void Visit(Triangle triangle)
        {
            TotalArea += 0.5 * triangle.Base * triangle.Height;
        }
    }
}
