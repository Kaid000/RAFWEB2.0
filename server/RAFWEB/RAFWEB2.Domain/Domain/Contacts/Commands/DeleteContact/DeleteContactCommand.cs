using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Contacts.Commands.DeleteContact
{
    public record DeleteContactCommand(ContactInfo ContactInfo) : IRequest<ContactInfo>
    {
    }
}
