using HotelProject.Business.Abstract;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribesController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribesController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }
        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _subscribeService.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(Subscribe subscribe)
        {
            _subscribeService.Insert(subscribe);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var value = _subscribeService.GetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateRoom(Subscribe subscribe)
        {
            _subscribeService.Update(subscribe);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var value = _subscribeService.GetByID(id);
            return Ok(value);
        }
    }
}
