using MediatorDesignPattern.Mediator;

namespace MediatorDesignPattern.Colleague
{
    /// <summary>
    /// Colleague Abstract Class
    /// </summary>
    public abstract class User
    {
        //This Property holds the name of the user
        protected string Name;
        //This Property is going to set and get the Mediator Instance
        //This Property value is going to be set when we register a user with the Mediator
        public IChatRoomMediator Mediator { get; set; }

        //Initializing the name using Constructor
        public User(string name)
        {
            Name = name;
        }
        //The following Methods are going to be Implemented by the Concrete Colleague
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
