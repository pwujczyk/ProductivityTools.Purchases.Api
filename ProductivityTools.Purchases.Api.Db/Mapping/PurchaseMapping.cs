using Microsoft.EntityFrameworkCore;
using ProductivityTools.Purchases.Contract;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProductivityTools.Purchases.Api.Database.Mapping
{
    public class PurchaseMapping : EntityTypeConfiguration<Purchase>
    {
        public PurchaseMapping()
        {
            //HasKey(x => x.Id).

            //Property(x=>x.Id).HasColumnName("PurchaseId");
            //HasMany(x => x.Items);

            ////HasOne<Dealer>().WithMany();

            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("PurchaseId");
           // Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            //HasMany(x => x.Items);
            //HasOptional(x => x.Dealer);
            //HasOne<Dealer>().WithMany();

        }
    }
}
