using Hotelproject.WebUI.Models.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hotelproject.WebUI.ViewComponents.Default;

public class _ServicesPartial:ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;
    public _ServicesPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("http://localhost:5135/api/Services");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ServiceViewModel>>(jsonData);
            return View(values);
        }
        return View();
    }
}
