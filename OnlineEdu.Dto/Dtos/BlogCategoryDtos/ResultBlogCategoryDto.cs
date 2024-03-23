using OnlineEdu.Dto.Dtos.BlogDtos;
using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Dto.Dtos.BlogCategoryDtos
{
    public class ResultBlogCategoryDto
    {
        public int BlogCategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<ResultBlogDto> Blogs { get; set; }
    }
}
