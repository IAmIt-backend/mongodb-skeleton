using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbDatabaseImplementation1.StorageModels
{
    public class UserGroupMembership
    {
        public Guid UserId { get; set; }
        public Guid GroupId { get; set; }
    }
}
