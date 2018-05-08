using Hbys.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;


namespace Hbys.Core
{
    public interface IGenericUnitOfWork : IDisposable
    {
        int Save();
    }

    public class GenericUnitOfWork : IDisposable
    {
        private HbysEntities _context;
        public GenericUnitOfWork()
        {
            _context = new HbysEntities();
        }

        private Dictionary<Type, object> repositories = new Dictionary<Type, object>();
        public IRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            if (repositories.Keys.Contains(typeof(TEntity)) == true)
            {
                return repositories[typeof(TEntity)] as IRepository<TEntity>;
            }
            IRepository<TEntity> repository = new GenericRepository<TEntity>(_context);
            repositories.Add(typeof(TEntity), repository);
            return repository;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}