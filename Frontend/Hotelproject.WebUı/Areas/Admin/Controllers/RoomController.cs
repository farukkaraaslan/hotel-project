using Hotelproject.WebUI.Areas.Admin.Models.Room;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http;

namespace Hotelproject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoomController : Controller
    {
        private readonly HttpClient _httpClient;

        public RoomController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5135/api/"); // API'nin adresini buraya girin
        }

        public async Task<IActionResult> Index()
        {
            var responseMessage = await _httpClient.GetAsync("Rooms");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<RoomViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
       
        [HttpPost]
        public async Task<IActionResult> Add(AddRoomModel room)
        {
            if (ModelState.IsValid)
            {
                    var content = new MultipartFormDataContent();
                    content.Add(new StringContent(room.Title), "Title");
                    content.Add(new StringContent(room.Number.ToString()), "Number");
                    content.Add(new StringContent(room.Price.ToString()), "Price");
                    content.Add(new StringContent(room.BedCount.ToString()), "BedCount");
                    content.Add(new StringContent(room.BathCount.ToString()), "BathCount");
                    content.Add(new StringContent(room.Wifi.ToString()), "Wifi");
                    content.Add(new StringContent(room.Description), "Description");
                    if (room.ImageFile != null)
                    {
                        var streamContent = new StreamContent(room.ImageFile.OpenReadStream());
                        content.Add(streamContent, "ImageFile", room.ImageFile.FileName);
                    }
                    var response = await _httpClient.PostAsync("Rooms", content);
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                
            }
            return View();
        }



        public async Task<IActionResult> Delete(int id)
        {
            
            var responseMessage = await _httpClient.DeleteAsync($"Rooms/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
 
            var responseMessage = await _httpClient.GetAsync($"Rooms/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateRoomModel>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateRoomModel room)
        {

                var content = new MultipartFormDataContent();

                // Diğer verileri ekleyin
                content.Add(new StringContent(room.Id.ToString()), "Id");
                content.Add(new StringContent(room.Title), "Title");
                content.Add(new StringContent(room.Number.ToString()), "Number");
                content.Add(new StringContent(room.Price.ToString()), "Price");
                content.Add(new StringContent(room.BedCount.ToString()), "BedCount");
                content.Add(new StringContent(room.BathCount.ToString()), "BathCount");
                content.Add(new StringContent(room.Wifi.ToString()), "Wifi");
                content.Add(new StringContent(room.Description), "Description");
                content.Add(new StringContent(room.CoverImage), "CoverImage");

                // Resim dosyasını ekleyin
                if (room.ImageFile != null)
                {
                    var streamContent = new StreamContent(room.ImageFile.OpenReadStream());
                    content.Add(streamContent, "ImageFile", room.ImageFile.FileName);
                }

                // API'ye gönderin
                var response = await _httpClient.PutAsync("Rooms", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            

            return View();
        }
    }
}
