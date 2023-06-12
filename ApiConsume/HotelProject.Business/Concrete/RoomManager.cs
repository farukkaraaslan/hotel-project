using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete;

public class RoomManager : IRoomService
{
    private readonly IRoomDal roomDal;

    public RoomManager(IRoomDal roomDal)
    {
        this.roomDal = roomDal;
    }

    public void Delete(Room entity)
    {
        roomDal.Delete(entity);
    }

    public List<Room> GetAll()
    {
        return roomDal.GetAll();
    }

    public Room GetByID(int id)
    {
        return roomDal.GetByID(id);
    }

    public void Insert(Room entity)
    {
        roomDal.Insert(entity);
    }

    public void Update(Room entity)
    {
       roomDal.Update(entity);
    }
}
