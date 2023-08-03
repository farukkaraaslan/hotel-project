using HotelProject.Business.Abstract;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutsController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var values = _aboutService.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult Add(About about)
        {
            _aboutService.Insert(about);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var value = _aboutService.GetById(id);
            _aboutService.Delete(value);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult Update(About about)
        {
            _aboutService.Update(about);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _aboutService.GetById(id);
            return Ok(value);
        }
    }
}
