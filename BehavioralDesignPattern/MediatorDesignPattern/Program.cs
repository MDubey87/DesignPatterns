//Create an Instance of Mediator i.e. Creating a Facebook Group
using MediatorDesignPattern.Colleague;
using MediatorDesignPattern.Mediator;

IChatRoomMediator mediator = new ChatRoom();
//Create instances of Colleague i.e. Creating users
User Ram = new ConcreteUser("Ram");
User Dave = new ConcreteUser("Dave");
User Smith = new ConcreteUser("Smith");
User Rajesh = new ConcreteUser("Rajesh");

//Registering the users with the Mediator i.e. Facebook Group
mediator.RegisterUser(Ram);
mediator.RegisterUser(Dave);
mediator.RegisterUser(Smith);
mediator.RegisterUser(Rajesh);
//One of the users Sending one Message in the Group
Dave.Send("Hello, everyone!");
Console.WriteLine();
//Another user Sending another Message in the Group
Rajesh.Send("Hi, Smith!");
Console.ReadLine();