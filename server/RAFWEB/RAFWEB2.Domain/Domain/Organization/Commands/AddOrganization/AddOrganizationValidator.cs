using FluentValidation;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Organization.Commands.AddOrganization
{
    public sealed class AddOrganizationValidator : AbstractValidator<AddOrganizationCommand>
    {
        public AddOrganizationValidator(IOrganizationRepository repo)
        {
            RuleFor(c => c.StudentOrganization.Name).Cascade(CascadeMode.StopOnFirstFailure).NotNull().Length(5, 50);

            RuleFor(c => c.StudentOrganization.Leader).Cascade(CascadeMode.StopOnFirstFailure).NotNull().Length(5, 50);
        }
    }
}
