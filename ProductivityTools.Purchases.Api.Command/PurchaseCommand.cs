using ProductivityTools.Purchases.Api.Database;
using ProductivityTools.Purchases.Contract;
using System;

namespace ProductivityTools.Purchases.Api.Command
{
    public class PurchaseCommand : IPurchaseCommand
    {
        IPurchaseRepository PurchaseRepository;

        public PurchaseCommand(IPurchaseRepository purchaseRepository)
        {
            this.PurchaseRepository = purchaseRepository;
        }

        public void AddPurchase(Purchase purchase)
        {
            this.PurchaseRepository.AddPurchase(purchase);
        }
    }
}
