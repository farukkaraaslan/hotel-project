using Microsoft.AspNetCore.Mvc;

namespace Hotelproject.WebUI.ViewComponents.Default;

public class _SliderPartial :ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
