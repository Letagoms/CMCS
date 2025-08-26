using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class ClaimSubmissionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
