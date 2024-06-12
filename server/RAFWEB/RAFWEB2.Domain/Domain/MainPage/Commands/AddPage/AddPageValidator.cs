using FluentValidation;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.MainPage.Commands.AddPage
{
    public sealed class AddPageValidator : AbstractValidator<AddPageCommand>
    {
        public AddPageValidator(IMainPageRepository repo)
        {
            RuleFor(c => c.MainPageContent.Title).Cascade(CascadeMode.StopOnFirstFailure).NotNull().Length(5, 50);
        }
    }
}
