using BridgePattern.Abstraction;
using BridgePattern.BridgeInterface;
using BridgePattern.Implementor;
using BridgePattern.RefinedAbstractions;

IDrawingEngine engineA = new DrawingEngineA();
IDrawingEngine engineB = new DrawingEngineB();

Shape circleA = new Circle(5, 10, 15, engineA);
Shape squareB = new Square(8, 20, 25, engineB);

circleA.Draw();
squareB.Draw();
Console.ReadLine();