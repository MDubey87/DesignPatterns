using CommandPattern.Command;

namespace CommandPattern.Invoker
{
    /// <summary>
    /// Invoker Class
    /// </summary>
    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }
}
