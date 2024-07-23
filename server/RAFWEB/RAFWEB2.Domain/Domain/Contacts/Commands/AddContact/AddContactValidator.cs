using FluentValidation;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Domain.Contacts.Commands.CreateContact;
using RAFWEB2.Domain.DTO;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Contacts.Commands.AddContact
{
    public sealed class AddContactValidator : AbstractValidator<ContactInfoDTO>
    {
        private dynamic Contacts { get; set; }

        public AddContactValidator(IContactInfoRepository repo)
        {
            ClassLevelCascadeMode = CascadeMode.Stop;
            RuleLevelCascadeMode = CascadeMode.Stop;
            Contacts = repo.GetAllQueryable();
            RuleFor(c => c.Address).NotNull().Must(MustBeUnique).WithMessage("Address must be unique!");

            RuleFor(c => c.Phone).NotNull().Length(12).Must(MustBeDigit).WithMessage("Phone must contains only from digits!");
        }

        private bool MustBeDigit(string phone)
        {
            return phone.All(Char.IsDigit);
        }

        private bool MustBeUnique(string Address)
        {
            foreach (var contact in Contacts)
            {
                if (contact.Address == Address)
                {
                    return false;
                }
            }

            return true;
        }
    }
}