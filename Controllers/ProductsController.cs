using Microsoft.AspNetCore.Mvc;

namespace MarmaraHijyen.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}