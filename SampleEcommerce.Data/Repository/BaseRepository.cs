using MongoDB.Driver;
using SampleEcommerce.Data.Entity;
using SampleEcommerce.Data.DbConnection;
using System;
using System.Collections.Generic;
using System.Text;
using SampleEcommerce.Core.Exceptions;

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
        /// <summary>
        /// Insert an item to table with type T
        /// </summary>
        /// <param name="entity"></param>
        virtual public void Add(T entity)
        {
            entity.CreatedDate = DateTime.Now.Ticks;
            _collection.InsertOne(entity);
        }
        /// <summary>
        /// Update an item from table with soft delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        virtual public long Delete(string id)
        {
            var item = Get(id);
            item.DeletedDate = DateTime.Now.Ticks;
            _collection.ReplaceOne(e => e.Id == id, item);
            return item.DeletedDate;
        }

        /// <summary>
        /// Get an item from table 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        virtual public T Get(string id)
        {
            return _collection.Find(e => e.Id == id && e.DeletedDate == 0).SingleOrDefault();
        }

        /// <summary>
        /// Get all items from table
        /// </summary>
        /// <returns></returns>
        virtual public List<T> GetAll()
        {
            return _collection.Find(e => e.DeletedDate == 0).ToList();
        }

        /// <summary>
        /// Update an item with new item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        virtual public long Update(string id, T entity)
        {
            entity.ModifiedDate = DateTime.Now.Ticks;
            return _collection.ReplaceOne(e => e.Id == id , entity).ModifiedCount;
        }
    }
}
