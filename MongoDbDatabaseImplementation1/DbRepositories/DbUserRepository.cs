using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAbstractions.Models;
using DatabaseAbstractions.Repositories;
using MongoDbDatabaseImplementation1.StorageModels;
using MongoDB.Driver;

namespace MongoDbDatabaseImplementation1.DbRepositories
{
    public class DbUserRepository : IUserRepository
    {
        private IMongoCollection<User> _collection; 
        public DbUserRepository ()
        {
            var client = new MongoClient();
            _collection = client.GetDatabase("mongodb").GetCollection<User>(nameof(User));
        }
        public async Task<FullUserInfo> GetUserInfoAsync(Guid id)
        {
            var user = _collection.AsQueryable().FirstOrDefault(u => u.Id == id);

        }

        public async Task<bool> SignIn(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
