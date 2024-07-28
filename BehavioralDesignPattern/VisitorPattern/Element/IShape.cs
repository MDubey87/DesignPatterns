using VisitorPattern.Visitor;

namespace VisitorPattern.Element
{
    /// <summary>
    /// Element Interface
    /// </summary>
    public interface IShape
    {
        void Accept(IVisitor visitor);
    }
}
