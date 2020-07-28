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

        public DbSet<Model.Purchase> Purchase { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("pc");
            modelBuilder.Entity<Model.Purchase>().HasKey(x => x.PurchaseId);
            modelBuilder.Entity<Model.PurchaseItem>().HasKey(x => x.PurchaseItemId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
