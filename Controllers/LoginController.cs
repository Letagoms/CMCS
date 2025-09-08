using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Login()
        {
            // Redirect to Home page after successful login
            return RedirectToAction("Index", "Home");
        }
    }
}
