using MongoDB.Driver;
using SampleEcommerce.Data.DbConnection;
using SampleEcommerce.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Data.Repository
{
    public class BasketRepository : BaseRepository<Basket> , IBasketRepository
    {
        public BasketRepository(IMongoConnectionProvider provider) : base(provider)
        {
        }

        public Basket GetByProductId(string productId)
        {
            return _collection.Find(e => e.ProductId == productId).SingleOrDefault();
        }
    }
}
