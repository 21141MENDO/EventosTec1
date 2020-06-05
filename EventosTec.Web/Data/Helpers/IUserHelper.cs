using EventosTec.Web.Models;
using EventosTec.Web.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventosTec.Web.Data.Helpers
{
    public interface  IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);
        Task<IdentityResult> AddUserAssync(User user, string Password);
        Task AddUserToRoleAsync(User user, string rolName);
        Task<bool> IsUserInRoleAsync(User user, string rolName);
        Task<SignInResult> LoginAsync(LoginViewModel model);
        Task LogoutAsync();
        Task GetUserByEMailAsync(string email);
        Task CheckRoleAsync(string v);
    }
}
