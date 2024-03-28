using OnlineEdu.WebUI.Dtos.CourseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.WebUI.Dtos.CourseCategoryDtos
{
    public class ResultCourseCategoryDto
    {
        public int CourseCategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryIcon { get; set; }
        public string Description { get; set; }
        public bool IsShown { get; set; }
        public List<ResultCourseDto> Courses { get; set; }
    }
}
