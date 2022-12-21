using Application.Features.Authors.Commands.UpdateAuthor;
using FluentValidation;

namespace Application.Features.Authors.Validations;

public class UpdateAuthorValidator : AbstractValidator<UpdateAuthorCommandRequest>
{
    public UpdateAuthorValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .NotNull()
            .WithMessage("İsim alanı boş geçilemez")
            .MaximumLength(30)
            .MinimumLength(2)
            .WithMessage("İsim alanı 2 ve 30 karakter arası girilebilir");

        RuleFor(x => x.Surname)
            .NotEmpty()
            .NotNull()
            .WithMessage("Soyisim alanı boş geçilemez")
            .MaximumLength(30)
            .MinimumLength(2)
            .WithMessage("Soyisim alanı 2 ve 30 karakter arası girilebilir");

        RuleFor(x => x.Age)
            .NotEmpty()
            .NotNull()
            .WithMessage("Yaş alanı boş geçilemez")
            .LessThanOrEqualTo(100)
            .GreaterThanOrEqualTo(5)
            .WithMessage("Yaşınız 5'den büyük ve 100'den küçük olmalıdır");
    }
}


