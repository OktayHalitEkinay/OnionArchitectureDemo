using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("memoryDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id=Guid.NewGuid(),Name="Book",Price=10,Quantity=20,CreateDate=DateTime.Now},
                new Product { Id=Guid.NewGuid(),Name="Computer",Price=1000,Quantity=15,CreateDate=DateTime.Now},
                new Product { Id=Guid.NewGuid(),Name="Pencil",Price=5,Quantity=150,CreateDate=DateTime.Now}
                );
            base.OnModelCreating(modelBuilder);
        }
      
    }

}
