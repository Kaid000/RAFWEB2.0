using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.MainPage.Queries.GetAllPages
{
    public class GetAllPagesQueryHandler : IRequestHandler<GetAllPagesQuery, List<MainPageContent>>
    {
        private readonly IMainPageRepository _repo;
        
        public GetAllPagesQueryHandler(IMainPageRepository repo)
        {
            _repo = repo;
        }

        public async  Task<List<MainPageContent>> Handle(GetAllPagesQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetAll();
        }
    }
}
