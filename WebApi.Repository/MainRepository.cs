using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WebApi.Domain.Entities;
using WebApi.Domain.Repositories;

namespace WebApi.Repository
{
    public class MainRepository<TEntity> : IMainRepository<TEntity> where TEntity : class
    {
        private readonly ProjectManagerEntities _context = new ProjectManagerEntities();
        private readonly DbSet<TEntity> _dbSet;
        public MainRepository(ProjectManagerEntities context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public IList<TEntity> GetList()
        {
            return _dbSet.ToList();
        }
    }
}
