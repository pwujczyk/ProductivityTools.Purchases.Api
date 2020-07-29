
namespace ProductivityTools.Purchase.Api.Command
{
    public interface IPurchaseCommand
    {
        void AddPurchase(Model.Purchase purchase);
    }
}