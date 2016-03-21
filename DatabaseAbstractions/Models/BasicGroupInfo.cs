using System;

namespace DatabaseAbstractions.Models
{
    public class BasicGroupInfo
    {
        public Guid GroupId { get; set; }
        public string GroupName { get; set; }
        public virtual int MembersCount { get; set; }
    }
}