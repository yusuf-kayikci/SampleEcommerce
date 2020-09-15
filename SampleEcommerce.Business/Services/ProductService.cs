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
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public bool IsValidEndDateForSell(string id)
        {
            var product = base.GetById(id);
            return (product?.SellEndDate != null) ? DateTime.Now < DateTime.Parse(product.SellEndDate)  : true;
        }

        public bool IsAvailableInStock(string id)
        {
            var product = base.GetById(id);
            return product?.Amount > 0;
        }
    }
}
