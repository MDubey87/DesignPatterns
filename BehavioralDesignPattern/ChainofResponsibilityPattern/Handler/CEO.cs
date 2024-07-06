using ChainofResponsibilityPattern.Model;

namespace ChainofResponsibilityPattern.Handler
{
    /// <summary>
    /// Concrete Handler 3
    /// </summary>
    public class CEO : IPurchaseHandler
    {
        public void HandleRequest(Purchase purchase)
        {
            Console.WriteLine($"CEO approved purchase of ${purchase.Amount}");
        }
    }
}
