using System.Collections.Generic;

namespace WebApi.Domain.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        IList<TEntity> GetList();
    }
}
