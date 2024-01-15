using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Contacts.Commands.DeleteContact
{
    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand, ContactInfo>
    {
        private readonly IContactInfoRepository _repo;

        public DeleteContactCommandHandler(IContactInfoRepository repo)
        {
            _repo = repo;
        }

        public async Task<ContactInfo> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            return await _repo.RemoveAsync(request.ContactInfo);
        }
    }
}
