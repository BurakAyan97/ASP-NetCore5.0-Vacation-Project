using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("ad alanı boş geçilemez");

            RuleFor(x => x.Surname)
                .NotEmpty()
                .WithMessage("soyadad alanı boş geçilemez");

            RuleFor(x => x.Mail)
                .NotEmpty()
                .WithMessage("mail alanı boş geçilemez");

            RuleFor(x => x.Username)
                .NotEmpty()
                .WithMessage("kullanıcı adı alanı boş geçilemez");

            RuleFor(x => x.Username)
                .MinimumLength(5)
                .WithMessage("Lütfen en az 5 karakter veri girişi yapınız");

            RuleFor(x => x.Username)
                .MaximumLength(20)
                .WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("şifre  alanı boş geçilemez");

            RuleFor(x => x.Password)
                .Equal(x => x.ConfirmPassword)
                .WithMessage("Şifreler birbiri ile uyuşmuyor");

            RuleFor(x => x.ConfirmPassword)
                .NotEmpty()
                .WithMessage("şifre tekrar alanı boş geçilemez");
        }
    }
}
