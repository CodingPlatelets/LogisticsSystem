using Microsoft.AspNetCore.Mvc;

namespace LogisticsSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
