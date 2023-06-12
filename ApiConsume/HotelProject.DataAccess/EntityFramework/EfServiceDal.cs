﻿using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.Repositories;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.EntityFramework;

public class EfServiceDal : GenericRepository<Services>, IServiceDal
{
    public EfServiceDal(ProjectContext context) : base(context)
    {
    }
}
