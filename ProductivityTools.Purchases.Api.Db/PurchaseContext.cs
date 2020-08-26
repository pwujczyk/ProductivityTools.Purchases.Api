using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using ProductivityTools.Purchases.Contract;

namespace ProductivityTools.Purchases.Api.Database
{
    public class PurchaseContext : DbContext
    {
        private readonly IConfiguration configuration;

        public PurchaseContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MilleniumContext"));
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Purchase> Purchase { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("pc");
            modelBuilder.Entity<Purchase>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<PurchaseItem>()
                .HasKey(x => x.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
