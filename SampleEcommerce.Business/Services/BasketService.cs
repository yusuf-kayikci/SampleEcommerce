using SampleEcommerce.Core.Abstractions;
using SampleEcommerce.Core.Exceptions;
using SampleEcommerce.Data.Entity;
using SampleEcommerce.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Business.Services
{
    public class BasketService : BaseService<Basket>, IBasketService
    {
        private readonly IProductService _productService;
        private readonly IBasketRepository _repository;
        public BasketService(IBasketRepository repository, IProductService productService) : base(repository)
        {
            _productService = productService;
            _repository = repository;
        }

        public override void Add(Basket entity)
        {
            if (_productService.IsAvailableInStock(entity.ProductId) && _productService.IsValidEndDateForSell(entity.ProductId)) 
            {
                if (entity.Amount == 0) entity.Amount = 1;
                _repository.Add(entity);
            }
            else
                throw new SampleEcommerceException("Bu ürün sepete eklenemez.");
        }

        public Basket GetBasketByProductId(string productId)
        {
            return _repository.GetByProductId(productId);
        }
    }
}
