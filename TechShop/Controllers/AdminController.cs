using Microsoft.AspNetCore.Mvc;

namespace TechShop.UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryView()
        {
            return View();
        }
    }
}
