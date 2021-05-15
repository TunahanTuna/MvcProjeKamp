using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Boş Olamaz!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen En Az 3 Karakter Giriniz!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En Fazla 50 Karakter Girebilirsiniz!");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Soyadı Boş Olamaz!");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("En Fazla 50 Karakter Girebilirsiniz!");
        }
    }
}
