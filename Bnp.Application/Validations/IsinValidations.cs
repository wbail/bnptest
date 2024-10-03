using FluentValidation;

namespace Bnp.Application.Validations;

public class IsinValidations : AbstractValidator<string>
{
    public IsinValidations()
    {
        RuleFor(x => x)
            .NotEmpty()
            .WithMessage("Isin is required")
            .Length(12)
            .WithMessage("Isin must be 12 characters long");
    }
}
