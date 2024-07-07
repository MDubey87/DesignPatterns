using StateDesignPattern.Context;

namespace StateDesignPattern.State
{
    /// <summary>
    /// Concrete State1
    /// </summary>
    public class DraftState : IDocumentState
    {
        public void Publish(Document document)
        {
            document.State = new ModerationState();
            Console.WriteLine("Document moved to Moderation state.");
        }

        public void Edit(Document document)
        {
            Console.WriteLine("Document is in Draft state. You can edit the document.");
        }
    }
}
