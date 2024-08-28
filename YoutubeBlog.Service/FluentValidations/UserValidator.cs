using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Service.FluentValidations
{
    public class UserValidator : AbstractValidator<AppUser>
    {
        public UserValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(150)
                .WithName("İsim");


            RuleFor(x => x.LastName)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(150)
                .WithName("Soyad");

            RuleFor(x => x.PhoneNumber)
               .NotEmpty()
               .MinimumLength(11)
               .MaximumLength(11)
               .WithName("Telefon Numarası");
        }
    }
}
