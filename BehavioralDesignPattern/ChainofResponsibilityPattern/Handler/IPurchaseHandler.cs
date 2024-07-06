using ChainofResponsibilityPattern.Model;

namespace ChainofResponsibilityPattern.Handler
{
    /// <summary>
    /// Handler Interface
    /// </summary>
    public interface IPurchaseHandler
    {
        void HandleRequest(Purchase purchase);
    }
}
