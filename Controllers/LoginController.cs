using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string loginEmail, string loginPassword, string role)
        {
            // You can add authentication logic here if needed

            if (role == "lecturer")
                return RedirectToAction("Index", "ClaimSubmission");
            if (role == "coordinator")
                return RedirectToAction("Index", "ViewClaims");
            if (role == "Manager")
                return RedirectToAction("Index", "Approvals");

            // If no role selected, reload page with error (optional)
            ViewBag.Error = "Please select your role.";
            return View();
        }
    }
}
    