using System;
using System.Linq;
using System.Linq.Expressions;

namespace Demo.Repository.Common
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> All();
        IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> filter, out int total, int index = 0, int size = 50);
        bool Contains(Expression<Func<TEntity, bool>> predicate);
        TEntity Find(params object[] keys);
        TEntity Find(Expression<Func<TEntity, bool>> predicate);
        TEntity Create(TEntity t);
        void Delete(TEntity t);
        void Delete(Expression<Func<TEntity, bool>> predicate);
        void Update(TEntity t);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> expression);
    }
}