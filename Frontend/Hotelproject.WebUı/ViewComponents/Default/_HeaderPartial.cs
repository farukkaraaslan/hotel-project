using Microsoft.AspNetCore.Mvc;

namespace Hotelproject.WebUI.ViewComponents.Default;

public class _HeaderPartial: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
