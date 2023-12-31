﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Core.Repositories;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    void Insert(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    List<TEntity> GetAll();
    TEntity GetByID(int id);
}
