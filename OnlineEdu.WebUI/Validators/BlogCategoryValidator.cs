using FluentValidation;
using OnlineEdu.WebUI.Dtos.BlogCategoryDtos;

namespace OnlineEdu.WebUI.Validators
{
    public class BlogCategoryValidator:AbstractValidator<CreateBlogCategoryDto>
    {
        public BlogCategoryValidator()
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Blog kategori adı boş bırakılamaz.");
            RuleFor(x=>x.CategoryName).MaximumLength(30).WithMessage("Blog kategori adı en fazla 30 karakter olabilir.");
        }
    }
}
