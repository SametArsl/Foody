using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _SideBarLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
