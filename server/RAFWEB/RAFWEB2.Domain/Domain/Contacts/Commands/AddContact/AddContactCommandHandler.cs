using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Contacts.Commands.CreateContact
{
    public class AddContactCommandHandler : IRequestHandler<AddContactCommand, ContactInfo>
    {
        private readonly IContactInfoRepository _repo;

        public AddContactCommandHandler(IContactInfoRepository repo)
        {
            _repo = repo;
        }

        public async Task<ContactInfo> Handle(AddContactCommand request, CancellationToken cancellationToken)
        {
            return await _repo.CreateAsync(request.ContactInfo);
        }
    }
}
