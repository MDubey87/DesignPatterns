using CommandPattern.Command;
using CommandPattern.Invoker;
using CommandPattern.Receiver;

Light livingRoomLight = new Light();
ICommand turnOnCommand = new TurnOnLightCommand(livingRoomLight);
ICommand turnOffCommand = new TurnOffLightCommand(livingRoomLight);

RemoteControl remote = new RemoteControl();
remote.SetCommand(turnOnCommand);
remote.PressButton(); // Turns on the light

remote.SetCommand(turnOffCommand);
remote.PressButton(); // Turns off the light
Console.ReadLine();