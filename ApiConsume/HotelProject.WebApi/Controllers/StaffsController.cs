using HotelProject.Business.Abstract;
using HotelProject.Core.Helpers.FileHelper;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly IStaffService staffService;

        public StaffsController(IStaffService staffService)
        {
            this.staffService = staffService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var list =staffService.GetAll();
            return Ok(list);
        }
        [HttpPost]
        public IActionResult Add([FromForm] Staff staff)
        {
            staffService.Insert(staff);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var value = staffService.GetById(id);
            staffService.Delete(value);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult Update([FromForm] Staff staff)
        {
            staffService.Update(staff);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = staffService.GetById(id);
            return Ok(value);
        }
    }
}
