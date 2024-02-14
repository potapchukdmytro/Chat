using Chat.ViewModels.Chat;
using FluentValidation;

namespace Chat.Validation
{
    public class CreateChatValidator : AbstractValidator<CreateChatVM>
    {
        public CreateChatValidator()
        {
            RuleFor(x => x.Title).NotEmpty().MinimumLength(5);
        }
    }
}
