using MongoDB.Driver;
using SampleEcommerce.Core.Abstractions;
using SampleEcommerce.Core.Entity;
using SampleEcommerce.Data.DbConnection;
using SampleEcommerce.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEcommerce.Data.Repository
{
    public abstract class BaseRepository<T> where T : BaseEntity
    {
        public readonly IMongoCollection<T> _collection;

        public BaseRepository(IMongoConnectionProvider provider)
        {
            var _db = provider.GetDatabase();
            _collection = _db.GetCollection<T>(typeof(T).Name);
        }

        virtual public void Add(T entity)
        {
            _collection.InsertOne(entity);
        }

        virtual public long Delete(string id)
        {
            return _collection.DeleteOne(e => e.Id == id).DeletedCount;
        }

        virtual public T Get(string id)
        {
            return _collection.Find(e => e.Id == id).SingleOrDefault();
        }

        virtual public List<T> GetAll()
        {
            return _collection.Find(e => true).ToList();
        }

        virtual public long Update(string id , T entity)
        {
            return _collection.ReplaceOne(e => e.Id == id, entity).ModifiedCount;
        }
    }
}
