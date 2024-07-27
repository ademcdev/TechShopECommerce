using Microsoft.AspNetCore.Mvc;

namespace TechShop.UI.ViewComponents.Layout
{
    [ViewComponent(Name = "Footer")]
    public class _FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
