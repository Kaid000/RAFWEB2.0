using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Contacts.Commands.CreateContact
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand, ContactInfo>
    {
        private readonly IContactInfoRepository _repo;

        public CreateContactCommandHandler(IContactInfoRepository repo)
        {
            _repo = repo;
        }

        public async Task<ContactInfo> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            return await _repo.CreateAsync(request.ContactInfo);
        }
    }
}
