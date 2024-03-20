using Microsoft.AspNetCore.Mvc;
using Sprint1_Sipaya.Models;

namespace Sprint1_Sipaya.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Check the username and password (replace this with your authentication logic)
            if (model.Username == "admin" && model.Password == "password")
            {
                // For simplicity, just redirect to a home page if login is successful
                return RedirectToAction("Index", "UserLoginViewModel");
            }

            ModelState.AddModelError("", "Invalid username or password");
            return View(model);
        }
    }
}
