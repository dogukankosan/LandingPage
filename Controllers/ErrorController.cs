using Microsoft.AspNetCore.Mvc;

namespace MarmaraHijyen.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/404")]
        public IActionResult Error404()
        {
            Response.StatusCode = 404;
            return View("Error404");
        }
        [Route("Error/{statusCode}")]
        public IActionResult HandleError(int statusCode)
        {
            // Tüm hataları 404'e yönlendir
            Response.StatusCode = statusCode;
            return View("Error404");
        }
    }
}