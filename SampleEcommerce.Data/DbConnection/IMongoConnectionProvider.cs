using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Data.DbConnection
{
    public interface IMongoConnectionProvider
    {
        void Connect();

        IMongoDatabase GetDatabase();
    }
}
