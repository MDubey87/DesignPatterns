using AbstractFactoryPatternExample.Factory;
using AbstractFactoryPatternExample.Product.Button;
using AbstractFactoryPatternExample.Product.TextBox;

// Create Windows UI
IUIFactory factory = new WindowUIFactory(); 
IButton button = factory.CreateButton();
ITextBox textBox = factory.CreateTextBox();

button.Render(); // This will render the appropriate button for the chosen factory.
textBox.Render(); // This will render the appropriate text box.

Console.WriteLine("-----------------------------------------------");

// Create Mac UI
IUIFactory factory1 = new MacUIFactory();
IButton button1 = factory1.CreateButton();
ITextBox textBox1 = factory1.CreateTextBox();

button1.Render(); // This will render the appropriate button for the chosen factory.
textBox1.Render(); // This will render the appropriate text box.

Console.ReadLine();