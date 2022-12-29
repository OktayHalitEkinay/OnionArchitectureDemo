using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Persistence.Context
{
    public class ApplicationDbContext:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }


    }

}
