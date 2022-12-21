using Application.Features.Authors.Commands.CreateAuthor;
using FluentValidation;

namespace Application.Features.Authors.Validations;

public class CreateAuthorValidator : AbstractValidator<CreateAuthorCommandRequest>
{
    public CreateAuthorValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .NotNull()
            .WithMessage("Ýsim alaný boþ geçilemez")
            .MaximumLength(30)
            .MinimumLength(2)
            .WithMessage("Ýsim alaný 2 ve 30 karakter arasý girilebilir");

        RuleFor(x => x.Surname)
            .NotEmpty()
            .NotNull()
            .WithMessage("Soyisim alaný boþ geçilemez")
            .MaximumLength(30)
            .MinimumLength(2)
            .WithMessage("Soyisim alaný 2 ve 30 karakter arasý girilebilir");

        RuleFor(x => x.Age)
            .NotEmpty()
            .NotNull()
            .WithMessage("Yaþ alaný boþ geçilemez")
            .LessThanOrEqualTo(100)
            .GreaterThanOrEqualTo(5)
            .WithMessage("Yaþýnýz 5'den büyük ve 100'den küçük olmalýdýr");
    }
}


