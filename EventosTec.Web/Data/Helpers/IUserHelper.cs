using EventosTec.Web.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventosTec.Web.Data.Helpers
{
    interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);
        Task<IdentityResult> addUserAssync(User user, string Password);
        Task CheckRoleAsync();
        Task AddUserToRoleAsync(User user, string rolName);
        Task<bool> IsUserInRoleAsync(User user, string rolName);
    }
}
