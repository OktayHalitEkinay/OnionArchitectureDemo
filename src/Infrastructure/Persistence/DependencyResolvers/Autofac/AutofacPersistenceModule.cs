

using Application.Interfaces.Repositories;
using Autofac;
using Persistence.Context;
using Persistence.Repositories;
using System;

namespace Application.DependencyResolvers.Autofac
{
    public class AutofacPersistenceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<ApplicationDbContext>();
        }
    }
}
