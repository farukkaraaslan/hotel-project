using Microsoft.AspNetCore.Mvc;

namespace Hotelproject.WebUI.Areas.Admin.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
