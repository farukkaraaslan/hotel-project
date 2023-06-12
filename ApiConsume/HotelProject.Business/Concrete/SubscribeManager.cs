using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete;

public class SubscribeManager : ISubscribeService

{
    private readonly ISubscribeDal subscribeDal;

    public SubscribeManager(ISubscribeDal subscribeDal)
    {
        this.subscribeDal = subscribeDal;
    }

    public void Delete(Subscribe entity)
    {
        subscribeDal.Delete(entity);
    }

    public List<Subscribe> GetAll()
    {
        return subscribeDal.GetAll();   
    }

    public Subscribe GetByID(int id)
    {
       return subscribeDal.GetByID(id);
    }

    public void Insert(Subscribe entity)
    {
       subscribeDal.Insert(entity);
    }

    public void Update(Subscribe entity)
    {
        subscribeDal.Update(entity);
    }
}
