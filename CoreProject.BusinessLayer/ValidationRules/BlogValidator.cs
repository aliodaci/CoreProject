using CoreProject.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            //RuleFor(x=>x.Title).NotEmpty().WithMessage("Blog Başlığını boş geçemezsiniz");
            //RuleFor(x => x.Content).NotEmpty().WithMessage("Blog içeriğini boş geçemezsiniz.");
            //RuleFor(x => x.Image).NotEmpty().WithMessage("Blog görselini boş geçemezisniz.");
           // RuleFor(x => x.Title).MaximumLength(150).WithMessage("200 karakter veri girişi yapın");
           // RuleFor(x => x.Title).MinimumLength(20).WithMessage("Başlık en az 20 karakter olamlıdır.");

        }
    }
}
