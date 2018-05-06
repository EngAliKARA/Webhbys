using Hbys.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Hbys.Core
{
    public interface IRepository<TEntity>
    {
        IList<TEntity> GetAll();
        IList<TEntity> Select(Expression<Func<TEntity, bool>> predicate);
        TEntity Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }

    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private HbysEntities _context;
        public GenericRepository(HbysEntities context)
        {
            _context = context;
        }
        public HbysEntities Context
        {
            get { return _context; }
            set { _context = value; }
        }
        public virtual IList<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }
         public virtual IList<TEntity> Select(Expression<Func<TEntity, bool>> Filter = null)
        {
            if (Filter != null)
                return _context.Set<TEntity>().Where(Filter).ToList();
            else
                return _context.Set<TEntity>().ToList();
        }
        public virtual TEntity SelectDetail(Expression<Func<TEntity, bool>> Filter = null)
        {
            if (Filter != null)
                return _context.Set<TEntity>().Where(Filter).FirstOrDefault();
            else
                return _context.Set<TEntity>().FirstOrDefault();
        }
        public virtual TEntity Insert(TEntity entity)
        {
            return _context.Set<TEntity>().Add(entity);
        }
        public virtual void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
    }
}


        

        /*
        public PersonelRepository(HbysEntities Context)
        {
            _context = Context;
            _dbSet = _context.Set<T>();
        }
        public virtual T FindById(object EntityId)
        {
            return _dbSet.Find(EntityId);
        }
        public virtual IEnumerable<T> Select(Expression<Func<T, bool>> Filter = null)
        {
            if (Filter != null)
            {
                return _dbSet.Where(Filter);
            }
            return _dbSet;
        }
        public virtual T SelectSingle(Expression<Func<T, bool>> Filter = null)
        {
            if (Filter != null)
            {
                return _dbSet.Where(Filter).SingleOrDefault();
            }
            return _dbSet.SingleOrDefault();
        }
        public virtual void Insert(T entity)
        {
            _dbSet.Add(entity);
        }
        public virtual void Update(T entityToUpdate)
        {
            _dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }
        public virtual void Delete(object EntityId)
        {
            T entityToDelete = _dbSet.Find(EntityId);
            Delete(entityToDelete);
        }
        public virtual void Delete(T Entity)
        {
            if (_context.Entry(Entity).State == EntityState.Detached) //Concurrency için 
            {
                _dbSet.Attach(Entity);
            }
            _dbSet.Remove(Entity);
        }*/

