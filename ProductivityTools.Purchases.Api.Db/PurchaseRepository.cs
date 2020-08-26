using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Purchases.Api.Database
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly PurchaseContext PurchaseContext;

        public PurchaseRepository(PurchaseContext context)
        {
            this.PurchaseContext = context;
        }

        public void AddPurchase(Contract.Purchase purchase)
        {
            this.PurchaseContext.Purchase.Add(purchase);
            this.PurchaseContext.SaveChanges();
        }
    }
}
