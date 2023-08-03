using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete;

public class BookingManager : IBookingService
{
    private readonly IBookingDal bookingDal;

    public BookingManager(IBookingDal bookingDal)
    {
        this.bookingDal = bookingDal;
    }

    public void Delete(Booking entity)
    {
        bookingDal.Delete(entity);  
    }

    public List<Booking> GetAll()
    {
        return bookingDal.GetAll();
    }

    public Booking GetById(int id)
    {
        return bookingDal.GetByID(id);
    }

    public void Insert(Booking entity)
    {
       bookingDal.Insert(entity);
    }

    public void Update(Booking entity)
    {
        bookingDal.Update(entity);
    }
}
