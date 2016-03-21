using System.Collections.Generic;

namespace DatabaseAbstractions.Models
{
    public enum GroupMemberType
    {
        Member,
        Administrator
    }

    public class GroupMember
    {
        public BasicUserInfo UserInfo { get; set; }
        public GroupMemberType MemberType { get; set; }
    }

    public class FullGroupInfo : BasicGroupInfo
    {
        public string Description { get; set; }
        public ICollection<GroupMember> GroupMembers { get; set; } = new List<GroupMember>();
        public override int MembersCount => GroupMembers.Count;
    }
}
