using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using Nutrition.UI.Services;

namespace Nutrition.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceLocator _serviceLocator;

        public HomeController(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View((object) _serviceLocator.GetInstance<ISimpleComponent>().Greeting());
        }
    }
}
