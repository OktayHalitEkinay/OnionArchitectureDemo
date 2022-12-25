

using Application.Interfaces.Repositories;
using Autofac;

namespace Application.DependencyResolvers.Autofac
{
    public class AutofacApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<ProductRepository>().As<IProductRepository>();

        }
    }
}
