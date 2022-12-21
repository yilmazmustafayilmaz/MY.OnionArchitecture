using Application.Features.Articles.Commands.UpdateArticle;
using FluentValidation;

namespace Application.Features.Articles.Validations;

public class UpdateArticleValidator : AbstractValidator<UpdateArticleCommandRequest>
{
    public UpdateArticleValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .NotNull()
            .WithMessage("Makale başlığı boş geçilemez")
            .MaximumLength(100)
            .MinimumLength(2)
            .WithMessage("Makale başlığı 2 ve 100 karakter arası girilebilir");

        RuleFor(x => x.Description)
            .NotEmpty()
            .NotNull()
            .WithMessage("Makale içeriği boş geçilemez")
            .MaximumLength(1000)
            .MinimumLength(10)
            .WithMessage("Makale içeriği 100 ve 1000 karakter arası girilebilir");
    }
}


