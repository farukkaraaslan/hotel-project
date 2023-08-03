using Hotelproject.WebUI.Models.Aboutus;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hotelproject.WebUI.ViewComponents.Default;

public class _AboutusPartial :ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _AboutusPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("http://localhost:5135/api/Abouts");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<AboutusViewModel>>(jsonData);
            return View(values);
        }
        return View();
    }
}
