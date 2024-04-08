using CommandPattern.Receiver;

namespace CommandPattern.Command
{
    /// <summary>
    /// Concrete Command
    /// </summary>
    public class TurnOffLightCommand : ICommand
    {
        private readonly Light _light;

        public TurnOffLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
