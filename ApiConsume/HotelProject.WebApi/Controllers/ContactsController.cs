using HotelProject.Business.Abstract;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService contactService;

        public ContactsController(IContactService contactService)
        {
           this.contactService = contactService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var list = contactService.GetAll();
            return Ok(list);
        }
        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            contactService.Insert(contact);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var values = contactService.GetById(id);
            contactService.Delete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(Contact contact)
        {
            contactService.Update(contact);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = contactService.GetById(id);
            return Ok(value);
        }
    }
}
