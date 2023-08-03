using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace HotelProject.Core.Repositories;

public class RepositoryBase<TEntity,TContext>: IRepositoryBase<TEntity> 
    where TEntity : class 
    where TContext : DbContext ,new()
{
    protected TContext context;

    public RepositoryBase(TContext context)
    {
        this.context = context;
    }

    public void Delete(TEntity entity)
    {
       
        context.Remove(entity);
        context.SaveChanges();
    }

    public List<TEntity> GetAll()
    {
       
        return context.Set<TEntity>().ToList();
    }

    public TEntity GetByID(int id)
    {
      
        return context.Set<TEntity>().Find(id);
    }

    public void Insert(TEntity entity)
    {
      
        context.Add(entity);
        context.SaveChanges();
    }

    public void Update(TEntity entity)
    {
     
        context.Update(entity);
        context.SaveChanges();
    }
}
