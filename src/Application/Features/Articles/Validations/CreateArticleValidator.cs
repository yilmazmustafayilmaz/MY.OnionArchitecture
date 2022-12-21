using Application.Features.Articles.Commands.CreateArticle;
using FluentValidation;

namespace Application.Features.Articles.Validations;

public class CreateArticleValidator : AbstractValidator<CreateArticleCommandRequest>
{
    public CreateArticleValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .NotNull()
            .WithMessage("Makale ba�l��� bo� ge�ilemez")
            .MaximumLength(100)
            .MinimumLength(2)
            .WithMessage("Makale ba�l��� 2 ve 100 karakter aras� girilebilir");

        RuleFor(x => x.Description)
            .NotEmpty()
            .NotNull()
            .WithMessage("Makale i�eri�i bo� ge�ilemez")
            .MaximumLength(1000)
            .MinimumLength(10)
            .WithMessage("Makale i�eri�i 100 ve 1000 karakter aras� girilebilir");
    }
}


