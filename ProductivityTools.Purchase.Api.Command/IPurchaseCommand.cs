
namespace ProductivityTools.Purchase.Api.Command
{
    public interface IPurchaseCommand
    {
        void AddPurchase(Contract.Purchase purchase);
    }
}