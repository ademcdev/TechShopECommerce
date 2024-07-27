using Microsoft.AspNetCore.Mvc;

namespace TechShop.UI.ViewComponents.Layout
{
    [ViewComponent(Name = "Header")]
    public class _HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
