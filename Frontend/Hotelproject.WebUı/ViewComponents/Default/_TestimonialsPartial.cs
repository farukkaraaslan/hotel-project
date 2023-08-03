using Hotelproject.WebUI.Models.Testimonial;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace Hotelproject.WebUI.ViewComponents.Default;

public class _TestimonialsPartial:ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;
    public _TestimonialsPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("http://localhost:5135/api/Testimonials");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<TestimonialViewModel>>(jsonData);
            return View(values);
        }
        return View();
    }
}
