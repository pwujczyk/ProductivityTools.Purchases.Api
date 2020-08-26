using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace ProductivityTools.Purchase.Api.Database
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

        public DbSet<Contract.Purchase> Purchase { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("pc");
            modelBuilder.Entity<Contract.Purchase>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Contract.PurchaseItem>()
                .HasKey(x => x.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
