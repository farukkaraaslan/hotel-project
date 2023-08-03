using Hotelproject.WebUI.Areas.Admin.Models.Staff;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Hotelproject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StaffController : Controller
    {
        private readonly HttpClient _httpClient;

        public StaffController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5135/api/"); // API'nin adresini buraya girin
        }

        public async Task<IActionResult> Index()
        {
            var responseMessage = await _httpClient.GetAsync("Staffs");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<StaffViewModel>>(jsonData);
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
        public async Task<IActionResult> Add(AddStaffViewModel staff)
        {
            if (ModelState.IsValid)
            {
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(staff.Name), "Name");
                content.Add(new StringContent(staff.Title), "Title");
                content.Add(new StringContent(staff.SocialMedia1), "SocialMedia1");
                content.Add(new StringContent(staff.SocialMedia2), "SocialMedia2");
                content.Add(new StringContent(staff.SocialMedia3), "SocialMedia3");
                if (staff.ImageFile != null)
                {
                    var streamContent = new StreamContent(staff.ImageFile.OpenReadStream());
                    content.Add(streamContent, "ImageFile", staff.ImageFile.FileName);
                }
                var response = await _httpClient.PostAsync("Staffs", content);

                // Hata ayrıntılarını kontrol etmek için içeriği okuyalım
                var responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseContent);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var responseMessage = await _httpClient.DeleteAsync($"Staffs/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"Staffs/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateStaffModel>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateStaffModel staff)
        {
            if (ModelState.IsValid)
            {
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(staff.Id.ToString()), "Id");
                content.Add(new StringContent(staff.Name), "Name");
                content.Add(new StringContent(staff.Title), "Title");
                content.Add(new StringContent(staff.SocialMedia1), "SocialMedia1");
                content.Add(new StringContent(staff.SocialMedia2), "SocialMedia2");
                content.Add(new StringContent(staff.SocialMedia3), "SocialMedia3");
                content.Add(new StringContent(staff.Image), "Image");
                if (staff.ImageFile != null)
                {
                    var streamContent = new StreamContent(staff.ImageFile.OpenReadStream());
                    content.Add(streamContent, "ImageFile", staff.ImageFile.FileName);
                }
                var response = await _httpClient.PutAsync("Staffs", content);

                // Hata ayrıntılarını kontrol etmek için içeriği okuyalım
                var responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseContent);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

            }
            return View();
        }
    }
}
