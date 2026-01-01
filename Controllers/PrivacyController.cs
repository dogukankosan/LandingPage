using Microsoft.AspNetCore.Mvc;

namespace MarmaraHijyen.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}