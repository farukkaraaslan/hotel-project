using HotelProject.Business.Abstract;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoomsController : ControllerBase
{
  private readonly IRoomService _roomService;

    public RoomsController(IRoomService _roomService)
    {
        this._roomService = _roomService;
    }


    [HttpGet]
    public IActionResult RoomList()
    {
        var values = _roomService.GetAll();
        return Ok(values);
    }
    [HttpPost]
    public IActionResult AddRoom(Room room)
    {
        _roomService.Insert(room);
        return Ok();
    }
    [HttpDelete]
    public IActionResult DeleteRoom(int id)
    {
        var value=_roomService.GetByID(id);
        return Ok(value);    
    }
    [HttpPut]
    public  IActionResult UpdateRoom(Room room)
    {
        _roomService.Update(room);
        return Ok();
    }
    [HttpGet("{id}")] 
    public IActionResult GetRoom(int id) 
    { 
        var value=_roomService.GetByID(id);
        return Ok(value);
    }
}
