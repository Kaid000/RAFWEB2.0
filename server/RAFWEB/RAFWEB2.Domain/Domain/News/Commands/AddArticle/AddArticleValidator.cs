using FluentValidation;
using RAFWEB2.Domain.Domain.News.Command.AddArticle;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.News.Commands.AddArticle
{
    public sealed class AddArticleValidator : AbstractValidator<AddArticleCommand>
    {
        public AddArticleValidator(IArticleRepository repo)
        {
            RuleFor(c => c.Article.Title).Cascade(CascadeMode.StopOnFirstFailure).NotNull().Length(5, 50);

            RuleFor(c => c.Article.HolidayId).Cascade(CascadeMode.StopOnFirstFailure).NotNull();
        }
    }
}
