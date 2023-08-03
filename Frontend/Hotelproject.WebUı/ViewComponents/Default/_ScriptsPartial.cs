using Microsoft.AspNetCore.Mvc;

namespace Hotelproject.WebUI.ViewComponents.Default;

public class _ScriptsPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
