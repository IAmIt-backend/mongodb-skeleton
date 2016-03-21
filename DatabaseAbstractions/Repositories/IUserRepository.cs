using System;
using System.Threading.Tasks;
using DatabaseAbstractions.Models;

namespace DatabaseAbstractions.Repositories
{
    public interface IUserRepository
    {
        Task<FullUserInfo> GetUserInfoAsync(Guid id);
        Task<bool> SignIn(string email, string password);
    }
}
