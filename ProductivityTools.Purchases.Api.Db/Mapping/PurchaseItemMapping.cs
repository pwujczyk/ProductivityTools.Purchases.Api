using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductivityTools.Purchases.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Purchases.Api.Database.Mapping
{
    class PurchaseItemMapping : IEntityTypeConfiguration<PurchaseItem>
    {
        public void Configure(EntityTypeBuilder<PurchaseItem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("PurchaseItemId");
        }
    }
}
