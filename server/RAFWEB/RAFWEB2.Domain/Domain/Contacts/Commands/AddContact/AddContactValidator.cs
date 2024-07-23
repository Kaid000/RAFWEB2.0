using FluentValidation;
using RAFWEB2.Domain.Domain.Contacts.Commands.CreateContact;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Contacts.Commands.AddContact
{
    public sealed class AddContactValidator : AbstractValidator<AddContactCommand>
    {
        public AddContactValidator(IContactInfoRepository repo)
        {
            ClassLevelCascadeMode = CascadeMode.Stop;
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(c => c.ContactInfo.Address).MustAsync(async (Address, _) =>
            {
                if (await repo.GetByAsync(c => c.Address == Address) == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }).WithMessage("The address must be unique");

            RuleFor(c => c.ContactInfo.Phone).NotNull().Length(12).Must(MustBeDigit);
        }

        private bool MustBeDigit(string phone)
        {
            return phone.All(Char.IsDigit);
        }
    }
}
