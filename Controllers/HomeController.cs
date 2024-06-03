using System.Linq;
using System.Web.Mvc;
using Type_D.Models;

namespace Type_D.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var services = _context.Services.ToList();
            return View(services);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}
