using HotelProject.Business.Abstract;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServicesController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _serviceService.GetAll();
            return Ok(list);
        }
        [HttpPost]
        public IActionResult Add(Services service)
        {
            _serviceService.Insert(service);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var values = _serviceService.GetById(id);
            _serviceService.Delete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(Services service)
        {
            _serviceService.Update(service);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _serviceService.GetById(id);
            return Ok(value);
        }
    }
}
