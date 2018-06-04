using System.Web.Mvc;

namespace dac_website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Information on DAC Construction";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact DAC Construction";

            return View();
        }
    }
}