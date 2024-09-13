using Microsoft.EntityFrameworkCore;
using System;
using testApi.Entities.appEntities;

namespace testApi.Entities
{
    public class Context2 : DbContext
    {
       
        public DbSet<Product2> Products { get; set; }
        public DbSet<Company2> Companies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-KP4MLAD\\MURAT;Database=MarketAppDB;TrustServerCertificate=True;Trusted_Connection=True;");
            }
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder) ////////////////////SEED
        //{Q
        //    base.OnModelCreating(modelBuilder);
        //    // Seed verileri ekleme
        //    modelBuilder.Entity<Product>().HasData(
        //        new Product {Name = "Test2", Stock = 1 },
        //        new Product {Name = "Test3", Stock = 2 }
        //    );
        //    modelBuilder.Entity<Company>().HasData(
        //        new Company {Name = "Apple" }
        //        );
        //}
    }
}

