using Chat.ViewModels.User;
using FluentValidation;

namespace Chat.Validation
{
    public class ProfileValidator : AbstractValidator<ProfileVM>
    {
        public ProfileValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8);
        }
    }
}
