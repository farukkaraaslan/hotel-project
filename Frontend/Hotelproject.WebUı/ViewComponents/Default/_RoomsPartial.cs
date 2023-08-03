using Hotelproject.WebUI.Models.Room;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hotelproject.WebUI.ViewComponents.Default;

public class _RoomsPartial:ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _RoomsPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("http://localhost:5135/api/Rooms");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<RoomViewModel>>(jsonData);
            return View(values);
        }
        return View();
    }
}
