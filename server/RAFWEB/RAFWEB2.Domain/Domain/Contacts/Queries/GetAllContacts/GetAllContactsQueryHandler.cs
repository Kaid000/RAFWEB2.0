using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Contacts.Queries.GetAllContacts
{
    public class GetAllContactsQueryHandler : IRequestHandler<GetAllContactsQuery,List<ContactInfo>>
    {
        private readonly IContactInfoRepository _repo;

        public GetAllContactsQueryHandler(IContactInfoRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<ContactInfo>> Handle(GetAllContactsQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetAll();
        }
    }
}
