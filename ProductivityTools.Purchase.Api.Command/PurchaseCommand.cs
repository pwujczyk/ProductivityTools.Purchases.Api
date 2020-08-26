using ProductivityTools.Purchase.Api.Database;
using System;

namespace ProductivityTools.Purchase.Api.Command
{
    public class PurchaseCommand : IPurchaseCommand
    {
        IPurchaseRepository PurchaseRepository;

        public PurchaseCommand(IPurchaseRepository purchaseRepository)
        {
            this.PurchaseRepository = purchaseRepository;
        }

        public void AddPurchase(Contract.Purchase purchase)
        {
            this.PurchaseRepository.AddPurchase(purchase);
        }
    }
}
