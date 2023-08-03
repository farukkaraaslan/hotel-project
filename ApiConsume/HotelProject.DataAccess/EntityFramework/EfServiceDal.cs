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

public class EfServiceDal : RepositoryBase<Services, ProjectContext>, IServiceDal
{
    public EfServiceDal(ProjectContext context) : base(context)
    {
    }
}
