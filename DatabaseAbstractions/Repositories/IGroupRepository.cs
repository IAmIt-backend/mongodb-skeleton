using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAbstractions.Models;

namespace DatabaseAbstractions.Repositories
{
    public interface IGroupRepository
    {
        Task<Guid> GetFullGroupInfoAsync();
        Task<bool> AddMemberAsync(Guid groupId, Guid userId);
        Task<bool> RemoveMemberAsync(Guid groupId, Guid userId);
        Task<bool> ChangeMemberTypeAsync(Guid groupId, Guid userId, GroupMemberType memberType);
    }
}
