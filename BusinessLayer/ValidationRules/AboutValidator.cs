using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    //Validasyon işlemi yapılacak Class'a AbstractValidator'dan miras aldırıyoruz.
    public class AboutValidator : AbstractValidator<About>//Parametre olarak Validasyon yapılacak sınıfı veriyoruz.
    {
        public AboutValidator()//FluentValidation metotlarını kullanabilmek için Constructor metot tanımlıyoruz.
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz...!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz...!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik açıklama bilgisi giriniz...!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Lütfen en fazla 1500 karakterlik açıklama bilgisi giriniz...!");
        }
    }
}
