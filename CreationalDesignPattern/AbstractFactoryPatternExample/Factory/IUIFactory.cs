using AbstractFactoryPatternExample.Product.Button;
using AbstractFactoryPatternExample.Product.TextBox;

namespace AbstractFactoryPatternExample.Factory
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
