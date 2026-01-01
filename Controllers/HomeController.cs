using System.Diagnostics;
using MarmaraHijyen.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarmaraHijyen.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}