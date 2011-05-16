using System.Web.Mvc;

namespace windsor_ioc_spike.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index() {
            return View();
        }

    }
}
