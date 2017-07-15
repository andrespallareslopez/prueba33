using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace prueba33.repositories
{
    public abstract class GenericRepositoryAsync<C, T> : IDisposable,
    IGenericRepositoryAsync<T> where T :
        class where C : DbContext, new()
    {
        private C _entities = new C();

        public C Context
        {
            get { return _entities; }
            set { _entities = value; }
        }
        public virtual void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
        }

        public async Task<T> AddAsync(T entity)
        {
            _entities.Set<T>().Add(entity);
            await _entities.SaveChangesAsync();
            return entity;
        }

        public virtual void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
        }

        public async Task<int> DeleteAsync(T entity)
        {
            _entities.Set<T>().Remove(entity);
            return await _entities.SaveChangesAsync();
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public Task<T> EditAsync(T entity)
        {
            throw new NotImplementedException();
        }
        public T Update(T entity, int key)
        {
            if (entity == null) return null;

            T existing = _entities.Set<T>().Find(key);
            if (existing != null)
            {
                _entities.Entry(existing).CurrentValues.SetValues(entity);
                _entities.SaveChanges();
            }

            return entity;
        }
        public async Task<T> UpdateAsync(T entity, int key)
        {
            if (entity == null) return null;

            T existing = await _entities.Set<T>().FindAsync(key);
            if (existing != null)
            {
                _entities.Entry(existing).CurrentValues.SetValues(entity);
                await _entities.SaveChangesAsync();
            }
            return existing;
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }

        public async Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> predicate)
        {

            IQueryable<T> query = _entities.Set<T>().Where(predicate);

            //return await _entities.Set<T>().Where(predicate).ToListAsync();
            return await query.ToArrayAsync();
        }

        public T Get(int id)
        {
            return _entities.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {

            IQueryable<T> query = _entities.Set<T>();
            return query;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entities.Set<T>().ToArrayAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _entities.Set<T>().FindAsync(id);
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _entities.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.Context.Dispose();
                    //Console.WriteLine("Estoy en dispose");
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
      }
    }