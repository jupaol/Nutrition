using Microsoft.Practices.ServiceLocation;
using Ninject.Modules;
using NinjectAdapter;

namespace Nutrition.DI
{
    public class ServiceLocatorModule : NinjectModule
    {
        public override void Load()
        {
            ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(Kernel));

            Kernel.Bind<IServiceLocator>().ToConstant(ServiceLocator.Current);
        }
    }
}