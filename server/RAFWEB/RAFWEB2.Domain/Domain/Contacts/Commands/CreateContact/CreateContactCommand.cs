using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Contacts.Commands.CreateContact
{
    public record CreateContactCommand(ContactInfo ContactInfo) : IRequest<ContactInfo>
    {
    }
}
