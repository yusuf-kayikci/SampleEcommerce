using SampleEcommerce.Core.Abstractions;
using SampleEcommerce.Data.Entity;
using SampleEcommerce.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Business.Services
{
    public class ProductService : BaseService<Product> , IProductService
    {
        public ProductService(IRepository<Product> repository) : base(repository)
        {
        }

        public bool CheckStock()
        {
            throw new NotImplementedException();
        }
    }
}
