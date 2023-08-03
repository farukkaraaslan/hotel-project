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
        public IActionResult GetAll()
        {
            var values = _subscribeService.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult Add(Subscribe subscribe)
        {
            _subscribeService.Insert(subscribe);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var value = _subscribeService.GetById(id);
            _subscribeService.Delete(value);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult Update(Subscribe subscribe)
        {
            _subscribeService.Update(subscribe);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _subscribeService.GetById(id);
            return Ok(value);
        }
    }
}
