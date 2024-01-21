using FlyweightPattern.FlyweightFactory;
using FlyweightPattern.FlyweightInterface;

FontFactory fontFactory = new FontFactory();

// Create font with different font name
IFont font1 = fontFactory.GetFont("Arial");
IFont font2 = fontFactory.GetFont("Times New Roman");

// Set intrinsic state
font1.SetSize(12);
font1.SetStyle("Regular");
font1.SetColor("Black");

font2.SetSize(14);
font2.SetStyle("Italic");
font2.SetColor("Red");

// Use flyweight objects
font1.Display("Hello, Flyweight Pattern!");
font2.Display("This is a demonstration.");

// Create another font using the same flyweight
IFont font3 = fontFactory.GetFont("Arial");
font3.Display("Same flyweight object");

Console.ReadLine();
