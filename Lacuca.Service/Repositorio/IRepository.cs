using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Lacuca.Service.Repositorio
{
  interface IRepository<T> where T : class
  {
    IQueryable<T> GetAll();
    IQueryable<T> Get(Expression<Func<T,bool>> predicate);
    T Find(params object[] key);
    T First(Expression<Func<T,bool>> predicate);
    void Insert(T entity);
    void Update(T entity);
    void Delete(Func<T, bool> predicate);
    void SaveChanges();
    void Dispose();
  }
}
