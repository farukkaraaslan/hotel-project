using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete;

public class ServiceManager : IServiceService
{
    private IServiceDal serviceDal;

    public ServiceManager(IServiceDal serviceDal)
    {
        this.serviceDal = serviceDal;
    }

    public void Delete(Services entity)
    {
        serviceDal.Delete(entity);
    }

    public List<Services> GetAll()
    {
        return serviceDal.GetAll();
    }

    public Services GetById(int id)
    {
      return  serviceDal.GetByID(id);
    }

    public void Insert(Services entity)
    {
       serviceDal.Insert(entity);
    }

    public void Update(Services entity)
    {
        serviceDal.Update(entity);
    }
}
