using HotelProject.Business.Abstract;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffsController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var list =_staffService.GetAll();
            return Ok(list);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.Insert(staff);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var values = _staffService.GetByID(id);
            _staffService.Delete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.Update(staff);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var value =_staffService.GetByID(id);
            return Ok(value);
        }
    }
}
