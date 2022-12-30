﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Persistence.Context
{
    public class ApplicationDbContext:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-MT6A41P;Initial Catalog=OnionArchitectureDemo;Integrated Security=True;TrustServerCertificate=True;Encrypt=false");
        }
        public DbSet<Product> Products { get; set; }


    }

}
