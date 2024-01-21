using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Organization.Queries.GetAllOrganization
{
    public record GetAllOrganizationQuery : IRequest<List<StudentOrganization>>
    {
    }
}
