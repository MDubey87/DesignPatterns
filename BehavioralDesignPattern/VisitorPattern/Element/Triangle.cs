using VisitorPattern.Visitor;

namespace VisitorPattern.Element
{
    /// <summary>
    /// Concrete Element3
    /// </summary>
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
