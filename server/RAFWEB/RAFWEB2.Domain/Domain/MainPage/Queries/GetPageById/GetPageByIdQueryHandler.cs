using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.MainPage.Queries.GetPageById
{
    public class GetPageByIdQueryHandler : IRequestHandler<GetPageByIdQuery, MainPageContent>
    {
        private readonly IMainPageRepository _repo;

        public GetPageByIdQueryHandler(IMainPageRepository repo)
        {
            _repo = repo;
        }
        public Task<MainPageContent> Handle(GetPageByIdQuery request, CancellationToken cancellationToken)
        {
            return _repo.GetByAsync(x => x.Id == request.id);
        }
    }
}
