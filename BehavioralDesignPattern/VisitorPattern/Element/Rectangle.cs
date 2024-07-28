using VisitorPattern.Visitor;

namespace VisitorPattern.Element
{
    /// <summary>
    /// Concrete Element2
    /// </summary>
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
