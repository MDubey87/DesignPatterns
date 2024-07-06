using ChainofResponsibilityPattern.Handler;
using ChainofResponsibilityPattern.Model;
// Create chain of responsibility
var ceo = new CEO();
var director = new Director(ceo);
var manager = new Manager(director);

// Process purchase requests
var purchase1 = new Purchase(800);
var purchase2 = new Purchase(3500);
var purchase3 = new Purchase(10000);

manager.HandleRequest(purchase1);
manager.HandleRequest(purchase2);
manager.HandleRequest(purchase3);
Console.ReadLine();