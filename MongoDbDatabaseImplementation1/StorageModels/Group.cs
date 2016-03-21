using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace MongoDbDatabaseImplementation1.StorageModels
{
    public class Group
    {
        public Guid Id { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
    }
}
