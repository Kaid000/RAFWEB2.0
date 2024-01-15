using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Contacts.Commands.UpdateContact
{
    public record UpdateContactCommand(ContactInfo ContactInfo) : IRequest<ContactInfo>
    {
        
    }
}
