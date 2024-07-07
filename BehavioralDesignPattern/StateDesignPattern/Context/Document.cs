using StateDesignPattern.State;

namespace StateDesignPattern.Context
{
    public class Document
    {
        public IDocumentState State { get; set; }

        public Document()
        {
            State = new DraftState();
        }

        public void Publish()
        {
            State.Publish(this);
        }

        public void Edit()
        {
            State.Edit(this);
        }
    }
}
