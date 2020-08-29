using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using ProductivityTools.Purchases.Contract;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using ProductivityTools.Purchases.Api.Database.Mapping;

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

            modelBuilder.ApplyConfiguration(new PurchaseMapping());
            modelBuilder.ApplyConfiguration(new DealerMapping());
            modelBuilder.ApplyConfiguration(new PaymentMapping());
            modelBuilder.ApplyConfiguration(new DeliveryMapping());
            modelBuilder.ApplyConfiguration(new PurchaseItemMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
