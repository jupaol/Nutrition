using System;
using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using Nutrition.UI.Services;
using slf4net;

namespace Nutrition.Controllers
{
    public partial class HomeController : Controller
    {
        private readonly IServiceLocator _serviceLocator;
        private readonly ILogger _logger;

        public HomeController(IServiceLocator serviceLocator, ILogger logger)
        {
            _serviceLocator = serviceLocator;
            _logger = logger;
        }

        public virtual ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            _logger.Trace("woooooooooooot" + DateTime.Now);

            return View((object) _serviceLocator.GetInstance<ISimpleComponent>().Greeting());
        }

        public virtual ActionResult ThrowException()
        {
            throw new NotImplementedException("Wuupsy");
        }
    }
}
