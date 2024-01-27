using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.MainPage.Commands.UpdatePage
{
    public class UpdatePageCommandHandler : IRequestHandler<UpdatePageCommand, MainPageContent>
    {
        private readonly IMainPageRepository _repo;

        public UpdatePageCommandHandler(IMainPageRepository repo)
        {
            _repo = repo;
        }

        public async Task<MainPageContent> Handle(UpdatePageCommand request, CancellationToken cancellationToken)
        {
            return await _repo.UpdateAsync(request.MainPageContent);
        }
    }
}
