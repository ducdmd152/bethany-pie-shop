using Microsoft.AspNetCore.Mvc;

namespace BethanyPieShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
