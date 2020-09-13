using SampleEcommerce.Data.DbConnection;
using SampleEcommerce.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Data.Repository
{
    public class ProductRepository : BaseRepository<Product> , IProductRepository
    {
        //I can access to _collection object 

        public ProductRepository(IMongoConnectionProvider provider) : base(provider)
        {
        }

    }
}
