using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace prueba33.repositories
{
   public interface IRepository<T>
    {
        T Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        T Get(Expression<Func<T, bool>> filter);
        ICollection<T> GetAll();
    }
}