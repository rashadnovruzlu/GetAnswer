using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GetAnswer.Service.EntityService
{
    public interface IService
    {
    }

    public interface IEntityService<T> : IService where T : BaseEntity
    {
        void Create(T entity);
        void CreateWithoutCommit(T entity);
        void CreateRange(IEnumerable<T> entities);
        void CreateRangeWithoutCommit(IEnumerable<T> entities);
        void Delete(T entity);
        void DeleteWithoutCommit(T entity);
        void DeleteRange(IEnumerable<T> entities);
        void DeleteRangeWithoutCommit(IEnumerable<T> entities);
        IEnumerable<T> GetAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
    }
}
