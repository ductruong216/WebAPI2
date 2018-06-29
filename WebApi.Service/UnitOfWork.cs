using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Domain.Entities;
using WebApi.Domain.Repositories;
using WebApi.Domain.UnitOfWork;
using WebApi.Repository;

namespace WebApi.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjectManagerEntities _context;
        private readonly Dictionary<Type, object> _repositories;
        public UnitOfWork()
        {
            _context = new ProjectManagerEntities();
            _repositories = new Dictionary<Type, object>();
        }

        public IMainRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            // Checks if the Dictionary Key contains the Model class
            if (_repositories.Keys.Contains(typeof(TEntity)))
            {
                // Return the repository for that Model class
                return _repositories[typeof(TEntity)] as IMainRepository<TEntity>;
            }

            // If the repository for that Model class doesn't exist, create it
            var repository = new MainRepository<TEntity>(_context);

            // Add it to the dictionary
            _repositories.Add(typeof(TEntity), repository);

            return repository;
        }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}