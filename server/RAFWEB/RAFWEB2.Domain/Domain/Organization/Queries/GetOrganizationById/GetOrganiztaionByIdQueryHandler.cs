using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Domain.Organization.Queries.GetAllOrganization;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Organization.Queries.GetOrganizationById
{
    public class GetOrganiztaionByIdQueryHandler : IRequestHandler<GetOrganizationByIdQuery, StudentOrganization>
    {
        private readonly IOrganizationRepository _repo;

        public GetOrganiztaionByIdQueryHandler(IOrganizationRepository repo)
        {
            _repo = repo;
        }

        public async Task<StudentOrganization> Handle(GetOrganizationByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetByAsync(x => x.Id == request.id);
        }
    }
}
