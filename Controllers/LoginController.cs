using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Login(/* login model parameters if any */)
        {
            // Validate login credentials here

            // Redirect to Home page after successful login
            return RedirectToAction("Index", "Home");
        }
    }
}
