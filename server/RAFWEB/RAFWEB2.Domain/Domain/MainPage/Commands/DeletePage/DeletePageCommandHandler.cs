using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.MainPage.Commands.DeletePage
{
    public class DeletePageCommandHandler : IRequestHandler<DeletePageCommand, MainPageContent>
    {
        private readonly IMainPageRepository _repo;

        public DeletePageCommandHandler(IMainPageRepository repo)
        {
            _repo = repo;
        }

        public async Task<MainPageContent> Handle(DeletePageCommand request, CancellationToken cancellationToken)
        {
            return await _repo.RemoveAsync(request.MainPageContent);
        }
    }
}
