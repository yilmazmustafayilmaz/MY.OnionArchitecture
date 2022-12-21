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
            .WithMessage("Makale baþlýðý boþ geçilemez")
            .MaximumLength(100)
            .MinimumLength(2)
            .WithMessage("Makale baþlýðý 2 ve 100 karakter arasý girilebilir");

        RuleFor(x => x.Description)
            .NotEmpty()
            .NotNull()
            .WithMessage("Makale içeriði boþ geçilemez")
            .MaximumLength(1000)
            .MinimumLength(10)
            .WithMessage("Makale içeriði 100 ve 1000 karakter arasý girilebilir");
    }
}


