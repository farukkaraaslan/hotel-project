using Hotelproject.WebUI.Areas.Admin.Models.Booking;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Hotelproject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookingController : Controller
    {
        private readonly HttpClient _httpClient;

        public BookingController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5135/api/"); // API'nin adresini buraya girin
        }

        public async Task<IActionResult> Index()
        {
            var responseMessage = await _httpClient.GetAsync("Bookings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<BookingViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }


        public async Task<IActionResult> UpdateStatus(int id, string newStatus)
        {

            var booking = new BookingViewModel
            {
                Id = id,
                Status = newStatus
            };

            var patchDocument = new JsonPatchDocument<BookingViewModel>();
            patchDocument.Replace(b => b.Status, booking.Status);

            var jsonData = JsonConvert.SerializeObject(patchDocument);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = await _httpClient.PatchAsync($"http://localhost:5135/api/Bookings/{id}", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

    }
}
