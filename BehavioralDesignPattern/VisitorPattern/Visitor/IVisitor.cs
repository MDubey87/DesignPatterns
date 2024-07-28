using VisitorPattern.Element;
namespace VisitorPattern.Visitor
{
    /// <summary>
    /// Visitor Interface
    /// </summary>
    public interface IVisitor
    {
        void Visit(Circle circle);
        void Visit(Rectangle rectangle);
        void Visit(Triangle triangle);
    }
}
