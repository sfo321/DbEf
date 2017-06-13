using EFCodeFirstProject.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EFCodeFirstProject
{
    public interface IData<TEntity> where TEntity : class, IEntity
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

        TEntity GetByID(object id);

        void Insert(TEntity entity);

        void Delete(TEntity entityToDelete);

        void Update(TEntity entityToUpdate);
    }
}