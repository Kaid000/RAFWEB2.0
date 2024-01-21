using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Organization.Commands.AddOrganization
{
    public record AddOrganizationCommand(StudentOrganization StudentOrganization) : IRequest<StudentOrganization>
    {
    }
}
