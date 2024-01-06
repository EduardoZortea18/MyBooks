using Domain.Entities;
using FluentValidation;

namespace Application.Validators
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(x => x.Author)
                .NotEmpty()
                .NotNull()
                .Length(50);

            RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull()
                .Length(50);

            RuleFor(x => x.Price)
                .GreaterThanOrEqualTo(0);
        }
    }
}
