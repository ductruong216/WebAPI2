using System;
using System.Collections.Generic;
using WebApi.Domain.Entities;
using WebApi.Domain.Repositories;
using WebApi.Domain.Services;
using WebApi.Domain.UnitOfWork;

namespace WebApi.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IUnitOfWork _unitOfWork;
        protected readonly IMainRepository<TEntity> _repositories;
        public BaseService()
        {
            _unitOfWork = new UnitOfWork();
            _repositories = _unitOfWork.Repository<TEntity>();
        }

        public IList<TEntity> GetList()
        {
           return _repositories.GetList();
        }
    }
}
