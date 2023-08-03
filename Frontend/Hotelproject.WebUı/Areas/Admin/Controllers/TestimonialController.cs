using Hotelproject.WebUI.Areas.Admin.Models.Testimonial;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using static HotelProject.Core.Utilities.Constants.Paths;

namespace Hotelproject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController : Controller
    {
        private readonly HttpClient _httpClient;

        public TestimonialController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5135/api/"); // API'nin adresini buraya girin
        }

        public async Task<IActionResult> Index()
        {
            var responseMessage = await _httpClient.GetAsync("Testimonials");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<TestimonialViewModel>>(jsonData);
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
        public async Task<IActionResult> Add(AddTestimonialModel testimonial)
        {
            if (ModelState.IsValid)
            {
                    var content = new MultipartFormDataContent();
                    content.Add(new StringContent(testimonial.Name), "Name");
                    content.Add(new StringContent(testimonial.Title), "Title");
                    content.Add(new StringContent(testimonial.Description), "Description");
                    if (testimonial.ImageFile != null)
                    {
                        var streamContent = new StreamContent(testimonial.ImageFile.OpenReadStream());
                        content.Add(streamContent, "ImageFile", testimonial.ImageFile.FileName);
                    }
                    var response = await _httpClient.PostAsync("Testimonials", content);

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
            var responseMessage = await _httpClient.DeleteAsync($"Testimonials/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"Testimonials/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateTestimonialModel>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateTestimonialModel testimonial)
        {
          
                var content = new MultipartFormDataContent();
            content.Add(new StringContent(testimonial.Id.ToString()), "Id");
            content.Add(new StringContent(testimonial.Name), "Name");
                content.Add(new StringContent(testimonial.Title), "Title");
                content.Add(new StringContent(testimonial.Description), "Description");
                content.Add(new StringContent(testimonial.Image), "Image");

                // Resim dosyasını ekleyin
                if (testimonial.ImageFile != null)
                {
                    var streamContent = new StreamContent(testimonial.ImageFile.OpenReadStream());
                    content.Add(streamContent, "ImageFile", testimonial.ImageFile.FileName);
                }

                // API'ye gönderin
                var response = await _httpClient.PutAsync("Testimonials", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            

            return View();
        }
    }
}

