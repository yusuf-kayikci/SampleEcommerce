using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Core.Abstractions
{
    public interface IService<T>
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
        T GetById(string id);
        long Delete(string id);
        long Update(string id ,T entity);
    }
}
