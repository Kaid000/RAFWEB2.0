using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Domain.Organization.Queries.GetAllOrganization;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Organization.Commands.DeleteOrganization
{
    public class DeleteOrganizationCommandHandler : IRequestHandler<DeleteOrganizationCommand, StudentOrganization>
    {
        private readonly IOrganizationRepository _repo;

        public DeleteOrganizationCommandHandler(IOrganizationRepository repo)
        {
            _repo = repo;
        }

        public async Task<StudentOrganization> Handle(DeleteOrganizationCommand request, CancellationToken cancellationToken)
        {
            return await _repo.RemoveAsync(request.StudentOrganization);
        }
    }
}
