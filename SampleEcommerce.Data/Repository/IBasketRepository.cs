using SampleEcommerce.Core.Abstractions;
using SampleEcommerce.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Data.Repository
{
    public interface IBasketRepository : IRepository<Basket>
    {
        Basket GetByProductId(string productId);

    }
}
