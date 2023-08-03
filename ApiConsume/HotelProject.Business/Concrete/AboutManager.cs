using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete;

public class AboutManager : IAboutService
{
    private readonly IAboutDal aboutDal;

    public AboutManager(IAboutDal aboutDal)
    {
        this.aboutDal = aboutDal;
    }

    public void Delete(About entity)
    {
      aboutDal.Delete(entity);
    }

    public List<About> GetAll()
    {
       return aboutDal.GetAll();
    }

    public About GetById(int id)
    {
       return aboutDal.GetByID(id);
    }

    public void Insert(About entity)
    {
        aboutDal.Insert(entity);
    }

    public void Update(About entity)
    {
     aboutDal.Update(entity);   
    }

}
