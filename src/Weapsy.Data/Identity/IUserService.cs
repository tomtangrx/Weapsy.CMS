﻿using System;
using System.Threading.Tasks;

namespace Weapsy.Data.Identity
{
    public interface IUserService
    {
        Task<UserRolesViewModel> GetUserRolesViewModelAsync(Guid id);
        Task CreateUserAsync(string email);
        Task AddUserToRoleAsync(Guid id, string roleName);
        Task RemoveUserFromRoleAsync(Guid id, string roleName);
        Task DeleteUserAsync(Guid id);
    }
}
