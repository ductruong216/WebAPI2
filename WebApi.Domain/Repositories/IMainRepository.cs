using System.Collections.Generic;

namespace WebApi.Domain.Repositories
{
    public interface IMainRepository<TEntity> where TEntity:class
    {
        IList<TEntity> GetList();
    }
}
