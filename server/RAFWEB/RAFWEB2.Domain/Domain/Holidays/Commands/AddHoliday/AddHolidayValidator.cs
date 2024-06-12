using FluentValidation;
using RAFWEB2.Domain.Domain.Holidays.Commands.CreateHoliday;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Holidays.Commands.AddHoliday
{
    public sealed class AddHolidayValidator : AbstractValidator<AddHolidayCommand>
    {
        public AddHolidayValidator(IHolidayRepository repo)
        {
            RuleFor(c => c.Holiday.PerformedDate).Cascade(CascadeMode.StopOnFirstFailure).NotNull().WithMessage("Performed date must be");

            RuleFor(c => c.Holiday.Title).Cascade(CascadeMode.StopOnFirstFailure).NotNull().Length(5, 50);
        }

    }
}
