using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen Rehber Adını Giriniz!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen Rehber Açıklamasını Giriniz!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen Rehber Görselini Giriniz!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen En Fazla 30 Karakter Giriniz!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Giriniz!");
        }
    }
}
