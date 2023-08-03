using Microsoft.AspNetCore.Mvc;

namespace Hotelproject.WebUI.ViewComponents.Default;

public class _HeadPartial: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
