namespace ProductivityTools.Purchase.Api.Database
{
    public interface IPurchaseRepository
    {
        void AddPurchase(Contract.Purchase puchase);
    }
}