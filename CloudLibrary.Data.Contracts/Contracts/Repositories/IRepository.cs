using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CloudLibrary.Data.Common.Contracts.Entities;

namespace CloudLibrary.Data.Common.Contracts.Repositories
{
    public interface IRepository<TEntity> where TEntity : IDirectoryEntity<string>
    {
        TEntity Get(object id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity Add(TEntity entity);
        void Remove(TEntity entity);
    }
}