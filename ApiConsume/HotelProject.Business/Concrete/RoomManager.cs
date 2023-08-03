using HotelProject.Business.Abstract;
using HotelProject.Core.Helpers.FileHelper;
using HotelProject.Core.Utilities.Constants;
using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.EntityFramework;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;

namespace HotelProject.Business.Concrete;

public class RoomManager : IRoomService
{
    private readonly IRoomDal roomDal;
    private readonly IFileHelper fileHelper;

    public RoomManager(IRoomDal roomDal, IFileHelper fileHelper)
    {
        this.roomDal = roomDal;
        this.fileHelper = fileHelper;
    }

    public void Delete(Room entity)
    {
        roomDal.Delete(entity);
    }

    public List<Room> GetAll()
    {
        return roomDal.GetAll();
    }

    public Room GetById(int id)
    {
        return roomDal.GetByID(id);
    }

    public void Insert(Room room)
    {

        var fileResult = fileHelper.AddFile(room.ImageFile, Paths.Room.Image);

        string imagePath = Path.Combine("images/room/", fileResult);

        room.CoverImage = imagePath;

       roomDal.Insert(room);
    }
    public void Update(Room room)
    {
        if (room.ImageFile != null)
        {

       
        var fileResult = fileHelper.UpdateFile( room.ImageFile, room.CoverImage, Paths.Room.Image);

        string imagePath = Path.Combine("images/room/", fileResult);
        room.CoverImage = imagePath;
        }
        else
        {
            room.CoverImage = room.CoverImage;
        }
        roomDal.Update(room);
    }
}
