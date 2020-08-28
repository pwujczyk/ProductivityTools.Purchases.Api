using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using ProductivityTools.Purchases.Contract;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace ProductivityTools.Purchases.Api.Database
{
    public class PurchaseContext : DbContext
    {
        public static readonly Microsoft.Extensions.Logging.LoggerFactory _myLoggerFactory =
    new LoggerFactory(new[] { new DebugLoggerProvider() });

        private readonly IConfiguration configuration;

        public PurchaseContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MilleniumContext"));
            optionsBuilder.UseLoggerFactory(_myLoggerFactory);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Purchase> Purchase { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("pc");
            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("PurchaseId");
               // entity.HasMany(x => x.Items);
               // entity.Property(x=>x.Dealer).
              //  entity.HasOne<Dealer>().WithMany();
            });

          //  modelBuilder.Entity<Purchase>().Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("PurchaseId");
           
            //modelBuilder.Entity<Purchase>().HasOne<Dealer>().WithMany();

            modelBuilder.Entity<PurchaseItem>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("PurchaseItemId");
            });

            /// modelBuilder.Entity<PurchaseItem>().Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("PurchaseItemId");

            modelBuilder.Entity<Dealer>(entity =>
            {
                entity.HasKey(d => d.Id);
                entity.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("DealerId");
            });

            // modelBuilder.Entity<Dealer>().Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("DealerId");


            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(d => d.Id);
                entity.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("PaymentId");
            });

            //modelBuilder.

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.HasKey(d => d.Id);
                entity.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("DeliveryId");
            });

            //   modelBuilder.Entity<Delivery>().Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("DeliveryId");

            base.OnModelCreating(modelBuilder);
        }
    }
}
