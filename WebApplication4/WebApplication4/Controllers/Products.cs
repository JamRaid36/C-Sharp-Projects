using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class Products : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
