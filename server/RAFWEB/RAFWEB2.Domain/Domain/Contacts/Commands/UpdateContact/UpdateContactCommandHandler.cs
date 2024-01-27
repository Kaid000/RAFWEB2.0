using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Contacts.Commands.UpdateContact
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand, ContactInfo>
    {
        private readonly IContactInfoRepository _repo;

        public UpdateContactCommandHandler(IContactInfoRepository repo)
        {
            _repo = repo;
        }

        public async Task<ContactInfo> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            return await _repo.UpdateAsync(request.ContactInfo);
        }
    }
}
