using Microsoft.AspNetCore.Mvc;

namespace MarmaraHijyen.Controllers
{
    public class TermsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}