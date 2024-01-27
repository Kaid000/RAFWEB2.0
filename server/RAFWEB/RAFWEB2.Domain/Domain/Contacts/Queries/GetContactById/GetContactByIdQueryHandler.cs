using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Contacts.Queries.GetContactById
{
    public class GetContactByIdQueryHandler : IRequestHandler<GetContactByIdQuery, ContactInfo>
    {
        private readonly IContactInfoRepository _repo;

        public GetContactByIdQueryHandler(IContactInfoRepository repo)
        {
            _repo = repo;
        }

        public async Task<ContactInfo> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetByAsync(x => x.Id == request.id);
        }
    }
}
