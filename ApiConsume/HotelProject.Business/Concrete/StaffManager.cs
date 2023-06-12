using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete;

public class StaffManager : IStaffService
{
    private readonly IStaffDal stafDal;

    public StaffManager(IStaffDal stafDal)
    {
        this.stafDal = stafDal;
    }

    public void Delete(Staff entity)
    {
        stafDal.Delete(entity);
    }

    public List<Staff> GetAll()
    {
        return stafDal.GetAll();
    }

    public Staff GetByID(int id)
    {
        return stafDal.GetByID(id);
    }

    public void Insert(Staff entity)
    {
        stafDal.Insert(entity);
    }

    public void Update(Staff entity)
    {
       stafDal.Update(entity);
    }
}
