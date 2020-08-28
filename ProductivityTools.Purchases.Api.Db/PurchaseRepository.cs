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
            //purchase.Items = new List<Contract.PurchaseItem>();
            //purchase.Payment = new Contract.Payment();
            //purchase.Delivery = new List<Contract.Delivery>();
            //purchase.Dealer = new Contract.Dealer();
            this.PurchaseContext.Purchase.Add(purchase);
            this.PurchaseContext.SaveChanges();
        }
    }
}
