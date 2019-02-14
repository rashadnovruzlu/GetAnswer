using DMS.Repository;
using Model.Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GetAnswer.Service.EntityService
{
    public abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {
        IUnitOfWork _unitOfWork;
        IGenericRepository<T> _repository;

        public EntityService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _repository.Add(entity);
            _unitOfWork.Commit();
        }

        public virtual void CreateWithoutCommit(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _repository.Add(entity);          
        }

        public void CreateRange(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }

            _repository.AddRange(entities);
            _unitOfWork.Commit();
        }
        public void CreateRangeWithoutCommit(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }

            _repository.AddRange(entities);
            
        }
        public virtual void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _repository.Edit(entity);
            _unitOfWork.Commit();
        }

        public virtual void UpdateWithoutCommit(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _repository.Edit(entity);
             
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }

            _repository.EditRange(entities);
            _unitOfWork.Commit();
        }

        public void UpdateRangeWithoutCommit(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }

            _repository.EditRange(entities);
            
        }

        public virtual void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _repository.Delete(entity);
            _unitOfWork.Commit();
        }

        public virtual void DeleteWithoutCommit(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _repository.Delete(entity);
            
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }

            _repository.DeleteRange(entities);
            _unitOfWork.Commit();
        }
        public void DeleteRangeWithoutCommit(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }

            _repository.DeleteRange(entities);
            
        }
        public virtual IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _repository.FindBy(predicate);
        }
    }
}
