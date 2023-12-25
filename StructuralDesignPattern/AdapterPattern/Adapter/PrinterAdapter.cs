using AdapterPattern.Adaptee;
using AdapterPattern.Target;

namespace AdapterPattern.Adapter
{
    // Adapter: Bridges the gap between OldPrinter and INewPrinter
    public class PrinterAdapter : INewPrinter
    {
        private readonly OldPrinter oldPrinter;

        public PrinterAdapter(OldPrinter oldPrinter)
        {
            this.oldPrinter = oldPrinter;
        }

        public void PrintNew()
        {
            // Call the old printer's method through the adapter
            oldPrinter.PrintOld();
        }
    }
}
