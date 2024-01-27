using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Domain.Organization.Queries.GetAllOrganization;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Organization.Commands.UpdateOrganization
{
    public class UpdateOrganizationCommandHandler : IRequestHandler<UpdateOrganizationCommand, StudentOrganization>
    {
        private readonly IOrganizationRepository _repo;

        public UpdateOrganizationCommandHandler(IOrganizationRepository repo)
        {
            _repo = repo;
        }

        public async Task<StudentOrganization> Handle(UpdateOrganizationCommand request, CancellationToken cancellationToken)
        {
            return await _repo.UpdateAsync(request.StudentOrganization);
        }
    }
}
