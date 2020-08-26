
using ProductivityTools.Purchases.Contract;

namespace ProductivityTools.Purchases.Api.Command
{
    public interface IPurchaseCommand
    {
        void AddPurchase(Purchase purchase);
    }
}