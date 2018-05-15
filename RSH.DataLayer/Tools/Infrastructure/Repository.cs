using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Models;
using Domain;

namespace DataLayer
{
    public class Repository<T> :
        Object, IRepository<T> where T : class
    {
        

        protected DbSet<T> DbSet { get; set; }
        protected ContextDB ContextDB { get; set; }

        public Repository(ContextDB contextDB):base()
        {
            if(contextDB==null)
            {
                throw (new ArgumentNullException("contextDB"));
            }
            ContextDB = contextDB;
            DbSet = ContextDB.Set<T>();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            DbSet.Remove(entity);
        }

        public bool DeleteByID(Guid id)
        {
            
            T oEntity = DbSet.Find(id);

            if (oEntity == null)
            {
                return (false);
            }
            else
            {
                Delete(oEntity);
                return (true);
            }
        }

        public IQueryable<T> Get()
        {
            return (DbSet);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return (DbSet.Where(predicate));
        }

        public T GetById(Guid id)
        {
            T obj = DbSet.Find(id);

            return (obj);
        }

        public IEnumerable<T> GetWithRawSql(string query, params object[] parameters)
        {
            return (DbSet.SqlQuery(query, parameters).ToList());
        }

        public virtual void Insert(T entity)
        {
            if(entity == null)
            { 
                throw new ArgumentNullException("entity");
            }
            DbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            //System.Data.Entity.EntityState oEntityState =
            //    ContextDB.Entry(entity).State;


            //if (oEntityState == System.Data.Entity.EntityState.Detached)
            //{
            //    DbSet.Attach(entity);
            //}


            //oEntityState =
            //    ContextDB.Entry(entity).State;


            ContextDB.Entry(entity).State =
                System.Data.Entity.EntityState.Modified;

            //oEntityState =
            //    ContextDB.Entry(entity).State;

        }
    }
}
