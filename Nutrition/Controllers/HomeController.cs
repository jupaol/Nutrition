using System.Web.Mvc;
using Nutrition.UI.Services;

namespace Nutrition.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISimpleComponent _simpleComponent;

        public HomeController(ISimpleComponent simpleComponent)
        {
            _simpleComponent = simpleComponent;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View((object) _simpleComponent.Greeting());
        }
    }
}
