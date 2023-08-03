using Hotelproject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hotelproject.WebUI.ViewComponents.Default;

public class _StaffPartial :ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;
    public _StaffPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("http://localhost:5135/api/Staffs");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<StaffViewModel>>(jsonData);
            return View(values);
        }
        return View();
    }
}
