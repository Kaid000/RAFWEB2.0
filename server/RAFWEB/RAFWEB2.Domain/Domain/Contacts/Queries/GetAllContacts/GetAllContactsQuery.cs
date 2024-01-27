using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Contacts.Queries.GetAllContacts
{
    public record GetAllContactsQuery : IRequest<List<ContactInfo>>
    {
    }
}
