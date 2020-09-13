using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Data.DbConnection
{
    public class MongoConnectionProvider : IMongoConnectionProvider
    {
        private IMongoDatabase _database;
        private readonly MongoConnectionSettings _settings;


        public MongoConnectionProvider(IOptions<MongoConnectionSettings> options)
        {
            _settings = options.Value;
        }
        public void Connect()
        {
            var mongoClient = new MongoClient(_settings.ConnectionString);
            _database = mongoClient.GetDatabase(_settings.DatabaseName);
        }

        public IMongoDatabase GetDatabase()
        {
            return _database;
        }
    }
}
