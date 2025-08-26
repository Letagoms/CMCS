using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class ViewClaimsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
