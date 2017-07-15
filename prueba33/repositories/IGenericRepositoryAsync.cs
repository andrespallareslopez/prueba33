using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Threading.Tasks;

namespace prueba33.repositories
{
    public interface IGenericRepositoryAsync<T> where T: class
    {
        IQueryable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        T Get(int id);
        Task<T> GetAsync(int id);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        Task<T> AddAsync(T entity);
        void Delete(T entity);
        Task<int> DeleteAsync(T entity);
        void Edit(T entity);
        Task<T> EditAsync(T entity);
        T Update(T entity, int key);
        Task<T> UpdateAsync(T entity, int key);
        void Save();
        Task<int> SaveAsync();

    }
}