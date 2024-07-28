using VisitorPattern.Visitor;

namespace VisitorPattern.Element
{
    /// <summary>
    /// Concrete Element1
    /// </summary>
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
