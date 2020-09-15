using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SampleEcommerce.Core.Abstractions;

namespace SampleEcommerce.Data.Entity
{
    public class BaseEntity : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public long ModifiedDate { get; set; }
        public long CreatedDate { get; set; }
        public long DeletedDate { get; set; }
    }
}
