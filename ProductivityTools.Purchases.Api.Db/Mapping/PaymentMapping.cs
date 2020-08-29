using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductivityTools.Purchases.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Purchases.Api.Database.Mapping
{
    class PaymentMapping : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("PaymentId");
        }
    }
}
