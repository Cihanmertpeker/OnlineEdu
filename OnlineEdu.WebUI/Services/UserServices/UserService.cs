using Microsoft.AspNetCore.Identity;
using OnlineEdu.Entity.Entities;
using OnlineEdu.WebUI.DTOs.UserDtos;

namespace OnlineEdu.WebUI.Services.UserServices
{
    public class UserService(UserManager<AppUser> _userManager,SignInManager<AppUser> _signInManager,RoleManager<AppRole> _roleManager) : IUserService
    {
        public Task<bool> AssignRoleAsync(List<AssignRoleDto> assignRoleDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateRoleAsync(UserRoleDto userRoleDto)
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityResult> CreateUserAsync(UserRegisterDto userRegisterDto)
        {
            var user = new AppUser
            {
                FirstName = userRegisterDto.FirstName,
                LastName = userRegisterDto.LastName,
                UserName = userRegisterDto.UserName,
                Email = userRegisterDto.Email,
            };
            if (userRegisterDto.Password != userRegisterDto.ConfirmPassword)
            {
                return new IdentityResult();
               
            }
            return await _userManager.CreateAsync(user, userRegisterDto.Password);
       
          
        }

        Task<bool> IUserService.LoginAsync(UserLoginDto userLoginDto)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUserService.LogoutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
