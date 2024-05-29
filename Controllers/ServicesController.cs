using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Type_D.Models;

namespace Type_D.Controllers
{
    public class ServicesController : Controller
    {
        private static List<Service> services = new List<Service>
        {
            new Service { Id = 1, Name = "Услуга 1", Description = "Описание услуги 1", Price = 100 },
            new Service { Id = 2, Name = "Услуга 2", Description = "Описание услуги 2", Price = 200 },
        };

        public ActionResult Index()
        {
            return View(services);
        }

        public ActionResult Details(int id)
        {
            var service = services.FirstOrDefault(s => s.Id == id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }

        [HttpGet]
        public ActionResult Book(int id)
        {
            var service = services.FirstOrDefault(s => s.Id == id);
            if (service == null)
            {
                return HttpNotFound();
            }
            var booking = new Booking { ServiceId = service.Id, ServiceName = service.Name };
            return View(booking);
        }

        [HttpPost]
        public ActionResult Book(Booking booking)
        {
            if (ModelState.IsValid)
            {
                // Здесь логика для сохранения бронирования
                return RedirectToAction("Index");
            }
            return View(booking);
        }
    }
}
