using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Domain.News.Queries.GetAllArticles;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Organization.Queries.GetAllOrganization
{
    public class GetAllOrganizationQueryHandler : IRequestHandler<GetAllOrganizationQuery, List<StudentOrganization>>
    {
        private readonly IOrganizationRepository _repo;

        public GetAllOrganizationQueryHandler(IOrganizationRepository repo)
        {
            _repo = repo;
        }

        public Task<List<StudentOrganization>> Handle(GetAllOrganizationQuery request, CancellationToken cancellationToken)
        {
            return _repo.GetAll();
        }
    }
}
