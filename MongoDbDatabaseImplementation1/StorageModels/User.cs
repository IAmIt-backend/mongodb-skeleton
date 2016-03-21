using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAbstractions.Models;

namespace MongoDbDatabaseImplementation1.StorageModels
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public IDictionary<ContactType, string> Contacts { get; set; } 

        // groups?
    }
}
