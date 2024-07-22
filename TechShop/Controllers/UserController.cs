using Microsoft.AspNetCore.Mvc;

namespace TechShop.UI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TestGround()
        {
            return View();
        }
    }
}
