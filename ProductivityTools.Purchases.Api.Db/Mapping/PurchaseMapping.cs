using Microsoft.EntityFrameworkCore;
using ProductivityTools.Purchases.Contract;
using System.Data.Entity.ModelConfiguration;

namespace ProductivityTools.Purchases.Api.Database.Mapping
{
    public class PurchaseMapping : EntityTypeConfiguration<Purchase>
    {
        public PurchaseMapping()
        {
            HasKey(x => x.Id).
                
            Property(x=>x.Id).HasColumnName("PurchaseId");
            HasMany(x => x.Items);
            
            //HasOne<Dealer>().WithMany();
        }
    }
}
