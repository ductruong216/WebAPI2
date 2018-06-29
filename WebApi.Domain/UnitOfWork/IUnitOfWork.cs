using WebApi.Domain.Repositories;

namespace WebApi.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        IMainRepository<TEntity> Repository<TEntity>() where TEntity : class;
        void BeginTransaction();
        void Commit();
        void Rollback();
        void Save();
        void Dispose();
    }
}
