using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.Repositories;

public class GenericRepository<TEntity>: IGenericDal<TEntity> where TEntity: class
{
    private readonly ProjectContext _context;

    public GenericRepository(ProjectContext context)
    {
        _context = context;
    }

    public void Delete(TEntity entity)
    {
        _context.Remove(entity);
        _context.SaveChanges();
    }

    public List<TEntity> GetAll()
    {
        return _context.Set<TEntity>().ToList();
    }

    public TEntity GetByID(int id)
    {
        return _context.Set<TEntity>().Find( id);   
    }

    public void Insert(TEntity entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        _context.Update(entity);    
        _context.SaveChanges(); 
    }
}
