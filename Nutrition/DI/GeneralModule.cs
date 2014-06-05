using Ninject.Extensions.Conventions;
using Ninject.Modules;
using Nutrition.UI.Services;

namespace Nutrition.DI
{
    public class GeneralModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind(config =>
                config.From(
                    typeof (GeneralModule).Assembly,
                    typeof (ISimpleComponent).Assembly)
                    .SelectAllClasses()
                    .Where(type => !string.IsNullOrWhiteSpace(type.Namespace) && type.Namespace.StartsWith("Nutrition"))
                    .BindAllInterfaces());

            
        }
    }
}