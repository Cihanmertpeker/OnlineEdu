﻿using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.UserDtos;
using OnlineEdu.WebUI.Services.UserServices;

namespace OnlineEdu.WebUI.ViewComponents.Home
{
    public class _HomeTeacherComponent(IUserService _userService) : ViewComponent
    {
       
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userService.GetAllTeachers();
            return View(values);
        }
    }
}
