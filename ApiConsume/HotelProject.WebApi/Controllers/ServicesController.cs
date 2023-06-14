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
        public IActionResult ServiceList()
        {
            var list = _serviceService.GetAll();
            return Ok(list);
        }
        [HttpPost]
        public IActionResult AddService(Services service)
        {
            _serviceService.Insert(service);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.GetByID(id);
            _serviceService.Delete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Services service)
        {
            _serviceService.Update(service);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var value = _serviceService.GetByID(id);
            return Ok(value);
        }
    }
}
