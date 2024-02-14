using Chat.ViewModels.Auth;
using FluentValidation;

namespace Chat.Validation
{
    public class LoginValidator : AbstractValidator<LoginVM>
    {
        public LoginValidator() 
        {
            RuleFor(x => x.Login).NotEmpty();
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8);
        }
    }
}
