using StateDesignPattern.Context;

namespace StateDesignPattern.State
{
    /// <summary>
    /// Concrete State2
    /// </summary>
    public class PublishedState : IDocumentState
    {
        public void Publish(Document document)
        {
            Console.WriteLine("Document is already published.");
        }

        public void Edit(Document document)
        {
            Console.WriteLine("Document is Published. You cannot edit the document.");
        }
    }
}
