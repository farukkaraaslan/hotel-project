using HotelProject.Core.Repositories;
using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.EntityFramework;

public class EfTestimonialDal : RepositoryBase<Testimonial, ProjectContext>, ITestimonialDal
{
    public EfTestimonialDal(ProjectContext context) : base(context)
    {
    }
}
