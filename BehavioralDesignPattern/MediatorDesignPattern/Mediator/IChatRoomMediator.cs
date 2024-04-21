using MediatorDesignPattern.Colleague;

namespace MediatorDesignPattern.Mediator
{
    /// <summary>
    /// Mediator Interface
    /// </summary>
    public interface IChatRoomMediator
    {
        void SendMessage(string message, User user);
        void RegisterUser(User user);
    }
}
