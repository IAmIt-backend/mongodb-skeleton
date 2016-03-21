using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAbstractions.Models;
using MongoDbDatabaseImplementation1.StorageModels;

namespace MongoDbDatabaseImplementation1
{
    public static class Conversions
    {
        public static FullUserInfo ToFullUserInfo(this User user)
        {
            return new FullUserInfo {UserId = user.Id, Groups = };
        }
    }
}
