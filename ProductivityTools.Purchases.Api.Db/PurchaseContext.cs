using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using ProductivityTools.Purchases.Contract;
using System.Security.Cryptography.X509Certificates;

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
                .HasKey(x => x.Id).HasName("PurchaseId");
            modelBuilder.Entity<Purchase>().Property(x => x.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Purchase>()
                .HasMany(x => x.Items);
            modelBuilder.Entity<Purchase>().HasOne<Dealer>().WithMany();

            modelBuilder.Entity<PurchaseItem>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Dealer>()
                .HasKey(d => d.Id).HasName("DelaerId");
            base.OnModelCreating(modelBuilder);
        }
    }
}
