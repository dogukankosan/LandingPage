using Microsoft.AspNetCore.Mvc;

namespace MarmaraHijyen.Controllers
{
    public class CertificatesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
