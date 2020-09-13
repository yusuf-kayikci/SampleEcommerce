using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Core.Abstractions
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T Get(string id);
        void Add(T entity);
        long Update(string id , T entity);
        long Delete(string id);
    }
}
