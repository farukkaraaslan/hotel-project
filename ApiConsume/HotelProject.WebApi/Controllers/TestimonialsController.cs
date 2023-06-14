using HotelProject.Business.Abstract;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialsController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _testimonialService.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(Testimonial testimonial)
        {
            _testimonialService.Insert(testimonial);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var value = _testimonialService.GetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateRoom(Testimonial testimonial)
        {
            _testimonialService.Update(testimonial);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var value = _testimonialService.GetByID(id);
            return Ok(value);
        }
    }
}
