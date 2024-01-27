using FluentValidation;
using RAFWEB2.Domain.Repositories.Interfaces;


namespace RAFWEB2.Domain.Domain.Achievement.Commands.AddAchievement
{
    public sealed class AddAchievementValidator : AbstractValidator<AddAchievementCommand>
    {
        public AddAchievementValidator(IAchievementRepository repo)
        {
            RuleFor(c => c.Achivement.Name).MustAsync(async (Name, _) =>
            {
                if (await repo.GetByAsync(c => c.Name == Name) == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }).WithMessage("The Name must be unique");


        }

    }
}
