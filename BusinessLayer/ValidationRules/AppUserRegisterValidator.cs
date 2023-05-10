using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez!");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez!");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez!");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Kullanıcı adı en az 5 karakter olmalı!");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Ad alanı en fazla 20 karakter olmalı!");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler uyuşmuyor!");
        }
    }
}
