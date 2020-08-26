namespace ProductivityTools.Purchases.Api.Database
{
    public interface IPurchaseRepository
    {
        void AddPurchase(Contract.Purchase puchase);
    }
}