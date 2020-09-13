using SampleEcommerce.Core.Abstractions;
using SampleEcommerce.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Data.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
