using Application.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ProductRepository: EfGenericRepository<Product>,IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext) { }

    }
}
