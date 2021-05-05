using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator: AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Olamaz!");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Giriniz!");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("En Fazla 50 Karakter Girebilirsiniz!");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori Açıklaması Boş Olamaz!");
            RuleFor(x => x.CategoryDescription).MaximumLength(200).WithMessage("En Fazla 200 Karakter Girebilirsiniz!");
        }
    }
}
