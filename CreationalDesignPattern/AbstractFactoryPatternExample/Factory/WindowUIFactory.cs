using AbstractFactoryPatternExample.Product.Button;
using AbstractFactoryPatternExample.Product.TextBox;

namespace AbstractFactoryPatternExample.Factory
{
    public class WindowUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WindowTextBox();
        }
    }
}
