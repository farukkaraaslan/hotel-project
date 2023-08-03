using Azure;
using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var values = _bookingService.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult Add(Booking booking)
        {
            _bookingService.Insert(booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var value = _bookingService.GetById(id);
            _bookingService.Delete(value);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult Update(Booking booking)
        {
            _bookingService.Update(booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _bookingService.GetById(id);
            return Ok(value);
        }
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] JsonPatchDocument<Booking> booking)
        {
            var entity = _bookingService.GetById(id);
            booking.ApplyTo(entity, ModelState);
            _bookingService.Update(entity);
            return Ok();
        }
    }
}
