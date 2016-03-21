using System;
using System.Collections.Generic;

namespace DatabaseAbstractions.Models
{
    public enum ContactType
    {
        Skype,
        Website,
        Twitter,
        Facebook
    }

    public class FullUserInfo : BasicUserInfo
    {
        public string Email { get; set; }

        public DateTime? Birthdate { get; set; }
        public IDictionary<ContactType, string> Contacts { get; set; } = new Dictionary<ContactType, string>(); 

        public ICollection<BasicGroupInfo> Groups { get; set; } = new List<BasicGroupInfo>(); 
    }
}
