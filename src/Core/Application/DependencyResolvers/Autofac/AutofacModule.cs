

using Autofac;

namespace Application.DependencyResolvers.Autofac
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<MongoProductDal>().As<IProductDal>().SingleInstance();
            //builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
        }
    }
}
