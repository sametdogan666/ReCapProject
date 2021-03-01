using Core.Entities.Concrete;
using FluentValidation;


namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.FirstName).MinimumLength(3);
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.LastName).MinimumLength(3);
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(p => p.Email).Must(Contains).WithMessage("Email @ işareti içermelidir");
        }

        private bool Contains(string arg)
        {
            return arg.Contains("@");
        }
    }
}
