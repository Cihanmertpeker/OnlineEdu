using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.UserDtos;
using OnlineEdu.WebUI.Services.UserServices;

namespace OnlineEdu.WebUI.ViewComponents.Home
{
    public class _HomeTeacherComponent : ViewComponent
    {
       
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
