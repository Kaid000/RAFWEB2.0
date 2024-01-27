using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Organization.Commands.DeleteOrganization
{
    public record DeleteOrganizationCommand(StudentOrganization StudentOrganization) : IRequest<StudentOrganization>
    {
    }
}
