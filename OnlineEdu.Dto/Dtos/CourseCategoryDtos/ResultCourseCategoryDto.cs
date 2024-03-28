using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Dto.Dtos.CourseCategoryDtos
{
    public class ResultCourseCategoryDto
    {
        public int CourseCategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryIcon { get; set; }
        public string Description { get; set; }
        public bool IsShown { get; set; }
        public List<Course> Courses { get; set; }

    }
}
