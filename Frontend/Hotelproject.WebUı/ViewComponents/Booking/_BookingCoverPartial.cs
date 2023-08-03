using Microsoft.AspNetCore.Mvc;

namespace Hotelproject.WebUI.ViewComponents.Booking;

public class _BookingCoverPartial :ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
