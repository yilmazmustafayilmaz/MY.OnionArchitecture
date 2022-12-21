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
            .WithMessage("�sim alan� bo� ge�ilemez")
            .MaximumLength(30)
            .MinimumLength(2)
            .WithMessage("�sim alan� 2 ve 30 karakter aras� girilebilir");

        RuleFor(x => x.Surname)
            .NotEmpty()
            .NotNull()
            .WithMessage("Soyisim alan� bo� ge�ilemez")
            .MaximumLength(30)
            .MinimumLength(2)
            .WithMessage("Soyisim alan� 2 ve 30 karakter aras� girilebilir");

        RuleFor(x => x.Age)
            .NotEmpty()
            .NotNull()
            .WithMessage("Ya� alan� bo� ge�ilemez")
            .LessThanOrEqualTo(100)
            .GreaterThanOrEqualTo(5)
            .WithMessage("Ya��n�z 5'den b�y�k ve 100'den k���k olmal�d�r");
    }
}


