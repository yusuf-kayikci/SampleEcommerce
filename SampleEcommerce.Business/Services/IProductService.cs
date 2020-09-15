using SampleEcommerce.Core.Abstractions;
using SampleEcommerce.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Business.Services
{
    public interface IProductService : IService<Product>
    {
        bool IsAvailableInStock(string id);
        bool IsValidEndDateForSell(string id);

    }
}
