using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IRepository<T> where T : class
    {

        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        bool DeleteByID(Guid id);
        T GetById(Guid id);

        IQueryable<T> Get();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);

        IEnumerable<T> GetWithRawSql(string query, params object[] parameters);

    }
}
