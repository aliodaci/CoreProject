using CoreProject.EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad boş geçilemez");
            RuleFor(x=>x.Email).EmailAddress().NotEmpty().WithMessage("Geçerli E-posta adresi giriniz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
            //RuleFor(x => x.Password).MinimumLength(8).WithMessage("En az 8 karakter");
           // RuleFor(x => x.Password).MaximumLength(20).WithMessage("En az 8 karakter olmalıdır.");
           // RuleFor(x => x.Password).Matches("[A-Z]").WithMessage("Bir adet büyük harf");
           // RuleFor(x => x.Password).Matches("[a-z]").WithMessage("Bir adet küçük harf");
           // RuleFor(x => x.Password).Matches("[0-9]").WithMessage("Bir adet sayı içermeli");
            //RuleFor(x => x.Password).Matches("[+/*.?/]").WithMessage("numerik karakter bir adet içermeli");


        }
    }
}
