using EventosTec.Web.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventosTec.Web.Data.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserHelper(UserManager<User>userManager, RoleManager<IdentityRole>roleManager) 
        {
            _userManager=userManager;
            _roleManager = roleManager;

        }
        public async Task<IdentityResult> addUserAssync(User user, string Password)
        {
            return await _userManager.CreateAsync(user,Password);
        }

        public async Task AddUserToRoleAsync(User user, string rolName)
        {
             await _userManager.AddToRoleAsync(user,rolName);
        }

        public async Task CheckRoleAsync(string rolName)
        {
            var roleExists = await _roleManager.RoleExistsAsync(rolName);
            if (!roleExists)
            {
                await _roleManager.CreateAsync(new IdentityRole
                { 
                    Name=rolName
                });
            }
        }

        public Task CheckRoleAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
                return user;
        }
 
        public async Task<bool> IsUserInRoleAsync(User user, string rolName)
        {
            return await _userManager.IsInRoleAsync(user, rolName);
        }
    }
}
