using AbstractFactoryPatternExample.Product.Button;
using AbstractFactoryPatternExample.Product.TextBox;

namespace AbstractFactoryPatternExample.Factory
{
    public class MacUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }
    }
}
