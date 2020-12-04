using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CloudLibrary.Data.Common
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(object id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        long Count();
        long Count(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> Top(int count);
        IEnumerable<TEntity> Top(int count, Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> ToList();
    }
}