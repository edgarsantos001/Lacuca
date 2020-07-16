using Lacuca.Service.DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;


namespace Lacuca.Service.Repositorio
{
  public class Repository<T> : IRepository<T>, IDisposable where T : class
  {
    private LacucaContext _context;
    public Repository(LacucaContext context)
    {
      this._context = context;
    }

    public IQueryable<T> GetAll()
    {
      return _context.Set<T>();
    }

    public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
    {
      return _context.Set<T>().Where(predicate);
    }

    public T Find(params object[] key)
    {
      return _context.Set<T>().Find(key);
    }

    public T First(Expression<Func<T, bool>> predicate)
    {
      return _context.Set<T>().Where(predicate).FirstOrDefault();
    }

    public void Insert(T entity)
    {
       _context.Set<T>().Add(entity);
    }

    public void Update(T entity)
    {
      _context.Entry(entity).State = EntityState.Modified; 
    }
    public void Delete(Func<T, bool> predicate)
    {
      _context.Set<T>().Where(predicate).ToList().ForEach(del => _context.Set<T>().Remove(del));
    }

    public void SaveChanges()
    {
      _context.SaveChanges();
    }

    public void Dispose()
    {
      if (_context != null)
      {
        _context.Dispose();
      }
      GC.SuppressFinalize(this);
    }
  }
}
