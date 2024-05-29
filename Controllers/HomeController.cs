using System.Web.Mvc;

namespace Type_D.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Описание дачных услуг.";
            return View();
        }
    }
}
