using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Organization.Commands.UpdateOrganization
{
    public record UpdateOrganizationCommand(StudentOrganization StudentOrganization) : IRequest<StudentOrganization>
    {
    }
}
