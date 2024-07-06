using ChainofResponsibilityPattern.Model;

namespace ChainofResponsibilityPattern.Handler
{
    /// <summary>
    /// Concrete Handler 1
    /// </summary>
    public class Manager : IPurchaseHandler
    {
        private readonly IPurchaseHandler _nextHandler;

        public Manager(IPurchaseHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void HandleRequest(Purchase purchase)
        {
            if (purchase.Amount <= 1000)
            {
                Console.WriteLine($"Manager approved purchase of ${purchase.Amount}");
            }
            else
            {
                _nextHandler.HandleRequest(purchase);
            }
        }
    }
}
