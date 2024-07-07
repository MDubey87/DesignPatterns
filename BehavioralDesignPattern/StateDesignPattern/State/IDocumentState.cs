using StateDesignPattern.Context;

namespace StateDesignPattern.State
{
    /// <summary>
    /// State Interface
    /// </summary>
    public interface IDocumentState
    {
        void Publish(Document document);
        void Edit(Document document);
    }
}
