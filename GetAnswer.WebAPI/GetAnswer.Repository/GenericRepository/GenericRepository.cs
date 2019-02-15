using GetAnswer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

namespace GetAnswer.Repository.GenericRepository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAsIQueryable();
        IEnumerable<T> GetAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        IEnumerable<T> AddRange(IEnumerable<T> entities);
        T Delete(T entity);
        IEnumerable<T> DeleteRange(IEnumerable<T> entities);
        void Edit(T entity);
        void EditRange(IEnumerable<T> entities);
        void Save();
    }


    public abstract class GenericRepository<T> : IGenericRepository<T>
      where T : BaseEntity
    {
        protected DbContext _entities;
        protected readonly IDbSet<T> _dbset;

        public GenericRepository(DbContext context)
        {
            _entities = context;
            _dbset = context.Set<T>();
        }

        public virtual IQueryable<T> GetAsIQueryable()
        {
            return _dbset;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.AsNoTracking().AsEnumerable();
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> query = _dbset.Where(predicate).AsEnumerable();
            return query;
        }

        public virtual T Add(T entity)
        {
            return _dbset.Add(entity);
        }

        public IEnumerable<T> AddRange(IEnumerable<T> entities)
        {
            return _entities.Set<T>().AddRange(entities);
        }

        public virtual T Delete(T entity)
        {
            DbEntityEntry dbEntityEntry = _entities.Entry(entity);

            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                _dbset.Attach(entity);

            }

            return _dbset.Remove(entity);
        }

        public IEnumerable<T> DeleteRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                DbEntityEntry dbEntityEntry = _entities.Entry(entity);

                if (dbEntityEntry.State != EntityState.Deleted)
                {
                    dbEntityEntry.State = EntityState.Deleted;
                }
                else
                {
                    _dbset.Attach(entity);
                    _dbset.Remove(entity);
                }
            }
            return entities;


        }

        public virtual void Edit(T entity)
        {
            try
            {
                _dbset.Attach(entity);
                _entities.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception e)
            {

            }
        }

        public void EditRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _dbset.Attach(entity);
                _entities.Entry(entity).State = EntityState.Modified;
            }
        }

        public virtual void Save()
        {
            try
            {
                _entities.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }

        }





    }
}
