using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductivityTools.Purchases.Contract;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProductivityTools.Purchases.Api.Database.Mapping
{
    public class PurchaseMapping : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("PurchaseId");
            builder.HasOne(purchase => purchase.Dealer).WithOne(dealer => dealer.Purchase).HasForeignKey<Dealer>(dealer => dealer.PurchaseId);
        }
    }
}
