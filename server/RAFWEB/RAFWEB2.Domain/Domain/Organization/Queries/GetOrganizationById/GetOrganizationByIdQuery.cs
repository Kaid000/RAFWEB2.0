using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Organization.Queries.GetOrganizationById
{
    public record GetOrganizationByIdQuery(Guid id) : IRequest<StudentOrganization>
    {
    }
}
