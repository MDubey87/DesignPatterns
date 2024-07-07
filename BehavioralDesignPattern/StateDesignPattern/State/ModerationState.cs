using StateDesignPattern.Context;

namespace StateDesignPattern.State
{
    /// <summary>
    /// Concrete State2
    /// </summary>
    public class ModerationState : IDocumentState
    {
        public void Publish(Document document)
        {
            document.State = new PublishedState();
            Console.WriteLine("Document moved to Published state.");
        }

        public void Edit(Document document)
        {
            Console.WriteLine("Document is in Moderation state. You cannot edit the document.");
        }
    }
}
