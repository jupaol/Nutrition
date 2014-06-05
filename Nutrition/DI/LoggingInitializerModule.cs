using Ninject.Modules;
using slf4net;

namespace Nutrition.DI
{
    public class LoggingInitializerModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<ILogger>().ToMethod(x =>
            {
                if (
                    x.Request != null &&
                    x.Request.Target != null &&
                    x.Request.Target.Member != null)
                {
                    return LoggerFactory.GetLogger(x.Request.Target.Member.ReflectedType);
                }

                return LoggerFactory.GetLogger(typeof(ILogger));
            });
        }
    }
}