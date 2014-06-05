using System.Web.Http;
using Ninject.Modules;
using Ninject.WebApi.DependencyResolver;

namespace Nutrition.DI
{
    public class WebApiModule : NinjectModule
    {
        public override void Load()
        {
            GlobalConfiguration.Configuration.DependencyResolver =
                new NinjectDependencyResolver(Kernel);
        }
    }
}