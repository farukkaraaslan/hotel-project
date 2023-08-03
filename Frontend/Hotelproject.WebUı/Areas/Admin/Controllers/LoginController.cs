using Hotelproject.WebUI.Areas.Admin.Models.User;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hotelproject.WebUI.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> singInManager;

        public LoginController(SignInManager<AppUser> singInManager)
        {
            this.singInManager = singInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginUserModel user)
        {
            if (user != null)
            {
                var result = await singInManager.PasswordSignInAsync(user.UserName, user.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Staff");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }
    }
}
