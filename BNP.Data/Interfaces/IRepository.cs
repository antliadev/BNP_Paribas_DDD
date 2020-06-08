using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BNP.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Commit();

        void Delete(T entity);

        void Dispose();

        void Update(T entity);

        void Insert(T entity);

        IQueryable<T> Get(Expression<Func<T, bool>> predicate);

        IEnumerable<T> GetAllNoTracking();

        T Find(params object[] key);
    }
}
