using ChainofResponsibilityPattern.Model;

namespace ChainofResponsibilityPattern.Handler
{
    /// <summary>
    /// Concrete Handler 2
    /// </summary>
    public class Director : IPurchaseHandler
    {
        private readonly IPurchaseHandler _nextHandler;

        public Director(IPurchaseHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void HandleRequest(Purchase purchase)
        {
            if (purchase.Amount <= 5000)
            {
                Console.WriteLine($"Director approved purchase of ${purchase.Amount}");
            }
            else
            {
                _nextHandler.HandleRequest(purchase);
            }
        }
    }
}
