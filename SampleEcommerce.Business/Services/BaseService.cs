using SampleEcommerce.Core.Abstractions;
using SampleEcommerce.Core.Exceptions;
using SampleEcommerce.Data.Entity;
using SampleEcommerce.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Business.Services
{
    public abstract class BaseService<T> where T : BaseEntity
    {
        private readonly IRepository<T> _repository;

        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }

        virtual public void Add(T entity)
        {
            _repository.Add(entity);
        }
        virtual public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }
        virtual public T GetById(string id)
        {
            return _repository.Get(id);
        }
        virtual public long Delete(string id)
        {
            return _repository.Delete(id);
        }
        virtual public long Update(string id , T entity)
        {
            return _repository.Update(id , entity);
        }






    }
}
