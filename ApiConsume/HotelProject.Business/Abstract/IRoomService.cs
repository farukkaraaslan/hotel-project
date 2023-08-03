using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Abstract;

public interface IRoomService
{
    void Insert(Room room);
    void Update(Room room);
    void Delete(Room room);
    List<Room> GetAll();
    Room GetById(int id);
}
