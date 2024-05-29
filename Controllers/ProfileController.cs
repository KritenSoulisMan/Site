using System.Web.Mvc;
using Type_D.Models;

namespace Type_D.Controllers
{
    public class ProfileController : Controller
    {
        private static UserProfile userProfile = new UserProfile
        {
            Name = "Иван Иванов",
            Email = "ivan@example.com",
            Password = "password"
        };

        public ActionResult Index()
        {
            return View(userProfile);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View(userProfile);
        }

        [HttpPost]
        public ActionResult Edit(UserProfile model)
        {
            if (ModelState.IsValid)
            {
                userProfile.Name = model.Name;
                userProfile.Email = model.Email;
                userProfile.Password = model.Password;
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
