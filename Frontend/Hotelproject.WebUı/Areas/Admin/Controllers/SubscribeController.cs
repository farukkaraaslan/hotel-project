using Hotelproject.WebUI.Areas.Admin.Models.Subscribe;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Hotelproject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubscribeController : Controller
    {
        private readonly HttpClient _httpClient;

        public SubscribeController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5135/api/"); // API'nin adresini buraya girin
        }

        public async Task<IActionResult> Index()
        {
            var responseMessage = await _httpClient.GetAsync("Subscribes");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<SubscribeViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }

    }
}
