namespace ChainofResponsibilityPattern.Model
{
    /// <summary>
    /// Request Class
    /// </summary>
    public class Purchase
    {
        public double Amount { get; }
        public Purchase(double amount)
        {
            Amount = amount;
        }
    }
}
