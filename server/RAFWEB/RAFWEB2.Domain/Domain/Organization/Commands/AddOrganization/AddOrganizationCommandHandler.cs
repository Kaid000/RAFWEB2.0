using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Domain.Organization.Queries.GetAllOrganization;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Organization.Commands.AddOrganization
{
    public class AddOrganizationCommandHandler : IRequestHandler<AddOrganizationCommand, StudentOrganization>
    {
        private readonly IOrganizationRepository _repo;

        public AddOrganizationCommandHandler(IOrganizationRepository repo)
        {
            _repo = repo;
        }

        public async Task<StudentOrganization> Handle(AddOrganizationCommand request, CancellationToken cancellationToken)
        {
            return await _repo.CreateAsync(request.StudentOrganization);
        }
    }
}
