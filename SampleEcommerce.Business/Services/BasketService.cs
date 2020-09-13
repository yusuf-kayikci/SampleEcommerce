using SampleEcommerce.Core.Abstractions;
using SampleEcommerce.Data.Entity;
using SampleEcommerce.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Business.Services
{
    public class BasketService : BaseService<Basket>, IBasketService
    {
        public BasketService(IRepository<Basket> repository) : base(repository)
        {
        }


    }
}
