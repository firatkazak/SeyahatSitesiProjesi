using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules.AnnouncementValidationRules
{
    public class AnnouncementUpdateValidator : AbstractValidator<AnnouncementUpdateDto>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlığı boş bırakamazsınız!");
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçeriği boş bırakamazsınız!");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("En az 5 karakter girmelisiniz!");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("En az 20 karakter girmelisiniz!");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("En fazla 50 karakter girmelisiniz!");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("En fazla 500 karakter girmelisiniz!");
        }
    }
}
