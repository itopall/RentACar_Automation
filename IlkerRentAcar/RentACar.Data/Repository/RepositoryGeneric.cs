using RentACar.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.Repository
{
    public class RepositoryGeneric<T> where T : class
    {
        private readonly RentACarEntities _racContext;
        private readonly IDbSet<T> _dbSet;

        //public RepositoryGeneric()
        //{
        //    _racContext = new RentACarEntities();
        //    _dbSet = _racContext.Set<T>();
        //}
        public RepositoryGeneric(RentACarEntities racContext)
        {
            _racContext = racContext;
            _dbSet = _racContext.Set<T>();
        }
        public virtual T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public virtual IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }
        public virtual IQueryable<T> GetAll(Expression<Func<T,bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }
        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }
        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _racContext.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
