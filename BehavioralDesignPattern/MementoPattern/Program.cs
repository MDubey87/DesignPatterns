// Create Originator and Caretaker objects
using MementoPattern;

Originator originator = new Originator();
Caretaker caretaker = new Caretaker();

// Set and save some states
originator.SetState("State 1");
caretaker.AddMemento(originator.SaveStateToMemento());

originator.SetState("State 2");
caretaker.AddMemento(originator.SaveStateToMemento());

originator.SetState("State 3");
caretaker.AddMemento(originator.SaveStateToMemento());

// Restore previous states
Console.WriteLine("\nRestoring states:");
originator.RestoreStateFromMemento(caretaker.GetMemento(0));
originator.RestoreStateFromMemento(caretaker.GetMemento(1));
Console.ReadLine();