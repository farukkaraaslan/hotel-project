using Microsoft.AspNetCore.Mvc;

namespace Hotelproject.WebUI.ViewComponents.Contact;

public class _ContactCoverPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
