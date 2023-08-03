using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Abstract;

public interface ITestimonialService
{
    void Insert(Testimonial testimonial);
    void Update(Testimonial testimonial);
    void Delete(Testimonial testimonial);
    List<Testimonial> GetAll();
    Testimonial GetById(int id);
}
