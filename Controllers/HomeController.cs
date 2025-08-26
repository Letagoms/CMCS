using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ViewClaims()
    {
        return View();
    }

    public IActionResult ClaimSubmission()
    {
        return View();
    }

    public IActionResult Approvals()
    {
        return View();
    }
}