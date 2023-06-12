using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete;

public class TestimonialManager : ITestimonialService
{
    private readonly ITestimonialDal testimonialDal;

    public TestimonialManager(ITestimonialDal testimonialDal)
    {
        this.testimonialDal = testimonialDal;
    }

    public void Delete(Testimonial entity)
    {
        testimonialDal.Delete(entity);
    }

    public List<Testimonial> GetAll()
    {
        return testimonialDal.GetAll();
    }

    public Testimonial GetByID(int id)
    {
       return testimonialDal.GetByID(id);
    }

    public void Insert(Testimonial entity)
    {
        testimonialDal.Insert(entity);
    }

    public void Update(Testimonial entity)
    {
        testimonialDal.Update(entity);
    }
}
