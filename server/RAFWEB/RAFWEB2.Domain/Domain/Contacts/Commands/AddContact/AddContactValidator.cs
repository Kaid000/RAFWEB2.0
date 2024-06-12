using FluentValidation;
using RAFWEB2.Domain.Domain.Contacts.Commands.CreateContact;
using RAFWEB2.Domain.Repositories.Interfaces;


namespace RAFWEB2.Domain.Domain.Contacts.Commands.AddContact
{
    public sealed class AddContactValidator : AbstractValidator<AddContactCommand>
    {
        public AddContactValidator(IContactInfoRepository repo)
        {
            RuleFor(c => c.ContactInfo.Address).Cascade(CascadeMode.StopOnFirstFailure).MustAsync(async (Address, _) =>
            {
                if (await repo.GetByAsync(c => c.Address == Address) == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }).WithMessage("The Name must be unique");

            RuleFor(c => c.ContactInfo.Phone).Cascade(CascadeMode.StopOnFirstFailure).NotNull().Length(12).Must(MustBeDigit);
        }

        private bool MustBeDigit(string phone)
        {
            return phone.All(Char.IsDigit);
        }
    }
}
