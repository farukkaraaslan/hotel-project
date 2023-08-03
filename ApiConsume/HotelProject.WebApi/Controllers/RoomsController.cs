using HotelProject.Business.Abstract;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoomsController : ControllerBase
{
  private readonly IRoomService _roomService;


    public RoomsController(IRoomService roomService)
    {
        _roomService = roomService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var values = _roomService.GetAll();
        return Ok(values);
    }
    [HttpPost]
    public IActionResult Add([FromForm] Room room)
    {
  
        _roomService.Insert(room);

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var value=_roomService.GetById(id);
        _roomService.Delete(value);
        return Ok(value);    
    }
    [HttpPut]
    public IActionResult Update([FromForm] Room room)
    {
        _roomService.Update(room);
        return Ok();
    }
    [HttpGet("{id}")] 
    public IActionResult GetById(int id) 
    { 
        var value=_roomService.GetById(id);
        return Ok(value);
    }
}
